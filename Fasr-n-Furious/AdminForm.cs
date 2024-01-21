using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fasr_n_Furious
{
    public partial class AdminForm : Form
    {
        private readonly int id;
        public AdminForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {

                var username = (from u in cars.Users
                                where u.user_id == id
                                select u.username).FirstOrDefault();
                AdminLabel.Text = username;

            }

            TableActionLabel.Text = "";
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void TableComboBox_TextChanged(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string table = TableComboBox.Text;
                if (!string.IsNullOrEmpty(table))
                {
                    string query = $"select * from {table}";

                    SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);
                    cmd.ExecuteNonQuery();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;

                    ActionComboBox.ResetText();
                }

                UserPanel.Visible = false;
                RolePanel.Visible = false;
                InfoPanel.Visible = false;
                RacePanel.Visible = false;

                if (table == "Users")
                {
                    UserPanel.Visible = true;
                }
                else if (table == "Roles")
                {
                    RolePanel.Visible = true;
                }
                else if (table == "UserInfos")
                {
                    InfoPanel.Visible = true;
                }
                else if (table == "Races")
                {
                    RacePanel.Visible = true;
                }
            }
        }

        private void ActionComboBox_TextChanged(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string table = TableComboBox.Text;
                string action = ActionComboBox.Text;
                if (!string.IsNullOrEmpty(action) && !string.IsNullOrEmpty(table))
                {
                    UserPanel.Visible = false;
                    RolePanel.Visible = false;
                    InfoPanel.Visible = false;
                    RacePanel.Visible = false;

                    if (table == "Users")
                    {
                        UserPanel.Visible = true;

                        if (action == "insert")
                        {
                            IdTextBox.ReadOnly = true;
                            IdTextBox.Clear();
                            VerifiedComboBox.Enabled = false;
                            UpdateButton.Visible = false;
                            DeleteButton.Visible = false;
                            InsertButton.Visible = true;
                        }
                        else if (action == "update")
                        {
                            IdTextBox.ReadOnly = false;
                            VerifiedComboBox.Enabled = true;
                            InsertButton.Visible = false;
                            DeleteButton.Visible = false;
                            UpdateButton.Visible = true;
                        }
                        else if (action == "delete")
                        {
                            IdTextBox.ReadOnly = false;
                            InsertButton.Visible = false;
                            UpdateButton.Visible = false;
                            DeleteButton.Visible = true;
                        }

                    }

                    else if (table == "Roles")
                    {
                        RolePanel.Visible = true;

                        if (action == "insert")
                        {
                            RoleIdTextBox.ReadOnly = true;
                            RoleIdTextBox.Clear();
                            RoleUpdateButton.Visible = false;
                            RoleDeleteButton.Visible = false;
                            RoleInsertButton.Visible = true;
                        }
                        else if (action == "update")
                        {
                            RoleIdTextBox.ReadOnly = false;
                            RoleInsertButton.Visible = false;
                            RoleDeleteButton.Visible = false;
                            RoleUpdateButton.Visible = true;
                        }
                        else if (action == "delete")
                        {
                            RoleIdTextBox.ReadOnly = false;
                            RoleInsertButton.Visible = false;
                            RoleUpdateButton.Visible = false;
                            RoleDeleteButton.Visible = true;
                        }
                    }

                    else if (table == "UserInfos")
                    {
                        InfoPanel.Visible = true;

                        if (action == "insert")
                        {
                            InfoIdTextBox.Clear();
                            InfoUpdateButton.Visible = false;
                            InfoDeleteButton.Visible = false;
                            InfoInsertButton.Visible = true;
                        }
                        else if (action == "update")
                        {
                            InfoInsertButton.Visible = false;
                            InfoDeleteButton.Visible = false;
                            InfoUpdateButton.Visible = true;
                        }
                        else if (action == "delete")
                        {
                            InfoInsertButton.Visible = false;
                            InfoUpdateButton.Visible = false;
                            InfoDeleteButton.Visible = true;
                        }
                    }

                    else if (table == "Races")
                    {
                        RacePanel.Visible = true;

                        if (action == "insert")
                        {
                            RaceIdTextBox.Enabled = false;
                            RaceIdTextBox.Clear();
                            RaceUpdateButton.Visible = false;
                            RaceDeleteButton.Visible = false;
                            RaceInsertButton.Visible = true;
                        }
                        else if (action == "update")
                        {
                            RaceIdTextBox.Enabled = true;
                            RaceInsertButton.Visible = false;
                            RaceDeleteButton.Visible = false;
                            RaceUpdateButton.Visible = true;
                        }
                        else if (action == "delete")
                        {
                            RaceIdTextBox.Enabled = true;
                            RaceInsertButton.Visible = false;
                            RaceUpdateButton.Visible = false;
                            RaceDeleteButton.Visible = true;
                        }
                    }

                    TableActionLabel.Text = $"{table} {action}";

                }
            }
        }

        #region User Buttons
        private void InsertButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("insert_users", (SqlConnection)con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                AddParameterIfNotEmpty(cmd, "@username", DbType.String, UsernameTextBox.Text);
                AddParameterIfNotEmpty(cmd, "@email", DbType.String, EmailTextBox.Text);
                AddParameterIfNotEmpty(cmd, "@password", DbType.String, PasswordTextBox.Text);
                AddParameterIfNotEmpty(cmd, "@role_id", DbType.Int32, RoleTextBox.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }


            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("insert_users", (SqlConnection)con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                AddParameterIfNotEmpty(cmd, "@user_id", DbType.Int32, IdTextBox.Text);
                AddParameterIfNotEmpty(cmd, "@username", DbType.String, UsernameTextBox.Text);
                AddParameterIfNotEmpty(cmd, "@email", DbType.String, EmailTextBox.Text);
                AddParameterIfNotEmpty(cmd, "@password", DbType.String, PasswordTextBox.Text);
                AddParameterIfNotEmpty(cmd, "@verified", DbType.Boolean, VerifiedComboBox.Text);
                AddParameterIfNotEmpty(cmd, "@role_id", DbType.Int32, RoleTextBox.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                SqlCommand cmd = new SqlCommand("delete_users", (SqlConnection)con)
                {
                    CommandType = CommandType.StoredProcedure
                };

                AddParameterIfNotEmpty(cmd, "user_id", DbType.Int32, IdTextBox.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }
        #endregion

        #region Role Buttons
        private void RoleInsertButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "insert into Roles([name]) values (@name)";

                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);
                if (string.IsNullOrEmpty(RoleNameTextBox.Text))
                {
                    MessageBox.Show("Enter name", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar);
                    cmd.Parameters["@name"].Value = RoleNameTextBox.Text;

                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void RoleUpdateButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "update Roles set name=@name where role_id=@role_id";

                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);
                if (string.IsNullOrEmpty(RoleIdTextBox.Text))
                {
                    MessageBox.Show("Enter role id", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(RoleNameTextBox.Text))
                {
                    MessageBox.Show("Enter name", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@name", SqlDbType.VarChar);
                    cmd.Parameters.AddWithValue("@role_id", SqlDbType.Int);
                    cmd.Parameters["@name"].Value = RoleNameTextBox.Text;
                    cmd.Parameters["@role_id"].Value = Convert.ToInt32(RoleIdTextBox.Text);

                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void RoleDeleteButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "delete from Roles where role_id=@role_id";

                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);

                if (string.IsNullOrEmpty(RoleIdTextBox.Text))
                {
                    MessageBox.Show("Enter role id", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@role_id", SqlDbType.Int);
                    cmd.Parameters["@role_id"].Value = Convert.ToInt32(RoleIdTextBox.Text);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region Info Buttons
        private void InfoInsertButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                SqlTransaction tran = ((SqlConnection)con).BeginTransaction();
                try
                { 
                    string insertQuery = "insert into UserInfos([name],[lastname],[age],[sex],[country],[user_id]) values(@name, @lastname, @age, @sex, @country, @user_id)";
                    SqlCommand insertCmd = new SqlCommand(insertQuery, (SqlConnection)con, tran);

                    string updateQuery = "update Users set verified = 1 where user_id = @user_id";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, (SqlConnection)con, tran);

                    if (string.IsNullOrEmpty(InfoIdTextBox.Text))
                    {
                        MessageBox.Show("Enter user id", "Empty field", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //insert user info
                        insertCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@name",
                            DbType = DbType.String,
                            Value = InfoNameTextBox.Text,
                            Direction = ParameterDirection.Input
                        });
                        insertCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@lastname",
                            DbType = DbType.String,
                            Value = LastnameTextBox.Text,
                            Direction = ParameterDirection.Input
                        });
                        insertCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@age",
                            DbType = DbType.Int32,
                            Value = Convert.ToInt32(AgeTextBox.Text),
                            Direction = ParameterDirection.Input
                        });
                        insertCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@sex",
                            DbType = DbType.String,
                            Value = SexComboBox.Text,
                            Direction = ParameterDirection.Input
                        });
                        insertCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@country",
                            DbType = DbType.String,
                            Value = CountryTextBox.Text,
                            Direction = ParameterDirection.Input
                        });
                        insertCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@user_id",
                            DbType = DbType.Int32,
                            Value = Convert.ToInt32(InfoIdTextBox.Text),
                            Direction = ParameterDirection.Input
                        });

                        insertCmd.ExecuteNonQuery();

                        //verified user
                        updateCmd.Parameters.Add(new SqlParameter
                        {
                            ParameterName = "@user_id",
                            DbType = DbType.Int32,
                            Value = Convert.ToInt32(InfoIdTextBox.Text),
                            Direction = ParameterDirection.Input
                        });

                        updateCmd.ExecuteNonQuery();
                    }

                    tran.Commit();
                }
                catch(Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                }

            }
        }

        private void InfoUpdateButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "update UserInfos set name=@name, lastname=@lastname, age=@age, sex=@sex, country=@country where user_id=@user_id";
                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);

                if (string.IsNullOrEmpty(InfoIdTextBox.Text))
                {
                    MessageBox.Show("Enter user id", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(InfoNameTextBox.Text))
                {
                    MessageBox.Show("Enter name", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(AgeTextBox.Text))
                {
                    MessageBox.Show("Enter age", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(SexComboBox.Text))
                {
                    MessageBox.Show("Enter sex", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(CountryTextBox.Text))
                {
                    MessageBox.Show("Enter country", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@name",
                        DbType = DbType.String,
                        Value = InfoNameTextBox.Text,
                        Direction = ParameterDirection.Input
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@lastname",
                        DbType = DbType.String,
                        Value = LastnameTextBox.Text,
                        Direction = ParameterDirection.Input
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@age",
                        DbType = DbType.Int32,
                        Value = Convert.ToInt32(AgeTextBox.Text),
                        Direction = ParameterDirection.Input
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@sex",
                        DbType = DbType.String,
                        Value = SexComboBox.Text,
                        Direction = ParameterDirection.Input
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@country",
                        DbType = DbType.String,
                        Value = CountryTextBox.Text,
                        Direction = ParameterDirection.Input
                    });
                    cmd.Parameters.Add(new SqlParameter
                    {
                        ParameterName = "@user_id",
                        DbType = DbType.Int32,
                        Value = Convert.ToInt32(InfoIdTextBox.Text),
                        Direction = ParameterDirection.Input
                    });

                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }

            }
        }

        private void InfoDeleteButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "delete from UserInfos where UserInfos.user_id=@user_id";

                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@user_id",
                    DbType = DbType.Int32,
                    Value = Convert.ToInt32(InfoIdTextBox.Text),
                    Direction = ParameterDirection.Input
                });

                if (string.IsNullOrEmpty(InfoIdTextBox.Text))
                {
                    MessageBox.Show("Enter user id", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
        #endregion

        #region Race Buttons
        private void RaceDeleteButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "delete from Races where race_id=@race_id";
                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@race_id",
                    DbType = DbType.Int32,
                    Value = Convert.ToInt32(RaceIdTextBox.Text),
                    Direction = ParameterDirection.Input
                });

                if (string.IsNullOrEmpty(RaceIdTextBox.Text))
                {
                    MessageBox.Show("Enter race id", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }

            }
        }

        private void RaceInsertButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "insert into Races(duration, points, user_id) values(@duration, @points, @user_id)";
                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);

                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@duration",
                    DbType = DbType.Time,
                    Value = Convert.ToDateTime(DurationTextBox.Text),
                    Direction = ParameterDirection.Input
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@points",
                    DbType = DbType.Int32,
                    Value = Convert.ToInt32(PointsTextBox.Text),
                    Direction = ParameterDirection.Input
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@user_id",
                    DbType = DbType.Int32,
                    Value = Convert.ToInt32(RaceUserIdTextBox.Text),
                    Direction = ParameterDirection.Input
                });

                if (string.IsNullOrEmpty(DurationTextBox.Text))
                {
                    MessageBox.Show("Enter duration", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(PointsTextBox.Text))
                {
                    MessageBox.Show("Enter points", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(RaceUserIdTextBox.Text))
                {
                    MessageBox.Show("Enter user id", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void RaceUpdateButton_Click(object sender, EventArgs e)
        {
            using (CarsEntities cars = new CarsEntities())
            {
                var con = cars.Database.Connection;
                con.Open();

                string query = "update Races set duration=@duration, points=@points, user_id=@user_id where race_id=@race_id";
                SqlCommand cmd = new SqlCommand(query, (SqlConnection)con);

                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@race_id",
                    DbType = DbType.Int32,
                    Value = Convert.ToInt32(RaceIdTextBox.Text),
                    Direction = ParameterDirection.Input
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@duration",
                    DbType = DbType.Time,
                    Value = Convert.ToDateTime(DurationTextBox.Text),
                    Direction = ParameterDirection.Input
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@points",
                    DbType = DbType.Int32,
                    Value = Convert.ToInt32(PointsTextBox.Text),
                    Direction = ParameterDirection.Input
                });
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = "@user_id",
                    DbType = DbType.Int32,
                    Value = Convert.ToInt32(RaceUserIdTextBox.Text),
                    Direction = ParameterDirection.Input
                });

                if (string.IsNullOrEmpty(RaceIdTextBox.Text))
                {
                    MessageBox.Show("Enter race id", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(DurationTextBox.Text))
                {
                    MessageBox.Show("Enter duration", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(PointsTextBox.Text))
                {
                    MessageBox.Show("Enter points", "Empty field", MessageBoxButtons.OK);
                }
                else if (string.IsNullOrEmpty(RaceUserIdTextBox.Text))
                {
                    MessageBox.Show("Enter user id", "Empty field", MessageBoxButtons.OK);
                }
                else
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
                    }
                }
            }
        }
        #endregion

        void AddParameterIfNotEmpty(SqlCommand cmd, string parameterName, DbType dbType, string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show($"Enter {parameterName.Substring(1)}", "Empty field", MessageBoxButtons.OK);
            }
            else
            {
                cmd.Parameters.Add(new SqlParameter
                {
                    ParameterName = parameterName,
                    DbType = dbType,
                    Value = value,
                    Direction = ParameterDirection.Input
                });
            }
        }
        private void LogoutLabel_Click(object sender, EventArgs e)
        {
            Hide();
            StartForm startForm = new StartForm();
            startForm.Show();
        }
    }
}
