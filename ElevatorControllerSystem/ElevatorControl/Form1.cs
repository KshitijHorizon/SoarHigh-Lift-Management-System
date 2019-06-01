using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Speech;
using System.Speech.Synthesis; //This code is used to use inbuild c#library  for talkback speech response

using System.Data.OleDb; //C# library that is used for connecting database


namespace ElevatorControl
{
    public partial class Form1 : Form
    {
        //These are the variable that will be used during the project development

        
        int y_up = 124;//The Y-cordinates of lift that will control 124 m for 1st floor


        int y_down = 442;//The Y-cordinates of lift that will control 124 m for Ground floor

        
        int x_door_left_close = 74;//The X-cordinates for left side of door during closing


        int x_door_left_open = 12;//The X-cordinates for left side of door during opening


        int x_door_right_close = 139;//The X-cordinates for right side of door closing

        
        int x_door_right_open = 200;//The X-cordinates for right side of door opening


        //This booleans check the status of lift 
        bool go_up = false;

        bool go_down = false;

        bool arrived_G = false;

        bool arrived_1 = false;

        //Variable for Voice Output during movement of lift
        
        
        SpeechSynthesizer reader = new SpeechSynthesizer();
 

        //Coding for Form by making objects and class ,, as this project is OOPS oriented
        
        
     
   



        public Form1()
        {
            InitializeComponent();
        }






        //This is a method that is used for down lift movement by clicking a downsided button intact in wall
 
        private void timer_lift_down_Tick(object sender, EventArgs e)
        {
            
            if (picture_lift.Top <= y_down)
            {
                picture_lift.Top += 1;
            }
            else
            {
                timer_lift_down.Enabled = false;
                btn_up.Enabled = true;
                btn_1.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_down.BackColor = Color.White;
                btn_G.BackColor = Color.White;
                

                door_open_down();
                arrived_G = true;

                picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::ElevatorControl.Properties.Resources.G;
                display_top.Image = global::ElevatorControl.Properties.Resources.G;
                display_bottom.Image = global::ElevatorControl.Properties.Resources.G;
            }
        }




        

        //This is a method that is used for up lift movement by clicking a upsided button intact in wall 

        private void timer_lift_up_Tick(object sender, EventArgs e)
        {
            if (picture_lift.Top >= y_up)
            {
                picture_lift.Top -= 1;
            }
            else
            {

                timer_lift_up.Enabled = false;
                btn_down.Enabled = true;
                btn_G.Enabled = true;
                btn_close.Enabled = true;
                btn_open.Enabled = true;
                btn_up.BackColor = Color.White;
                btn_1.BackColor = Color.White;

                door_open_up();
                arrived_1 = true;


                picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;

                display_panel.Image = global::ElevatorControl.Properties.Resources._1;
                display_top.Image = global::ElevatorControl.Properties.Resources._1;
                display_bottom.Image = global::ElevatorControl.Properties.Resources._1;
            }
        }






        //This is a method that is used for opening lift doors by clicking a openlift button intact in control panel 
        
        private void door_open_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left >= x_door_left_open && door_right_down.Left <= x_door_right_open)
            {
                door_left_down.Left -= 1;
                door_right_down.Left += 1;
            }
            else
            {

                timer_door_open_down.Enabled = false;

            }
        }







        //This is a method that is used for closing lift doors by clicking a Closelift button intact in control panel 


        private void door_close_down_Tick(object sender, EventArgs e)
        {
            if (door_left_down.Left <= x_door_left_close && door_right_down.Left >= x_door_right_close)
            {
                door_left_down.Left += 1;
                door_right_down.Left -= 1;
            }
            else
            {
                timer_door_close_down.Enabled = false;
                

                if (go_up == true)
                {
                    picture_lift.Image = global::ElevatorControl.Properties.Resources.lift_transparent;

                    display_panel.Image = global::ElevatorControl.Properties.Resources.up;
                    display_top.Image = global::ElevatorControl.Properties.Resources.up;
                    display_bottom.Image = global::ElevatorControl.Properties.Resources.up;


                    //Speech BackTalk When Lift is going up 
                    reader.Speak("Elevator is Departing Upstairs"); 


                    timer_lift_up.Enabled = true;
                    go_up = false;
                }
            }
        }






        //This is a method that is used for opening lift doors by clicking a Openlift button intact in control panel 

        private void timer_door_open_up_Tick(object sender, EventArgs e)
        {
           
           //Condition that checks whether if lift doors are in close position or not 

            if (door_left_up.Left >= x_door_left_open && door_right_up.Left <= x_door_right_open)
            {
                door_left_up.Left -= 1;
                door_right_up.Left += 1;
            }
            else
            {
                timer_door_open_up.Enabled = false;

            }
        }

       
        
        
        
        //This is the method that enables the function of closing door when doorClose button is clicked in control panel

        private void timer_door_close_up_Tick(object sender, EventArgs e)
        {
            if (door_left_up.Left <= x_door_left_close && door_right_up.Left >= x_door_right_close)
            {
                door_left_up.Left += 1;
                door_right_up.Left -= 1;
            }
            else
            {
                timer_door_close_up.Enabled = false;

                
                if (go_down == true)
                {
                    picture_lift.Image = global::ElevatorControl.Properties.Resources.lift_transparent;

                    display_panel.Image = global::ElevatorControl.Properties.Resources.down;
                    display_top.Image = global::ElevatorControl.Properties.Resources.down;
                    display_bottom.Image = global::ElevatorControl.Properties.Resources.down;


                    reader.Speak("Elevator is Departing Downstairs");

                    timer_lift_down.Enabled = true;
                    go_down = false;
                }
            }
        }









        //These methods are created so that the code can be used as by call by reference in next method which is controlling function
        private void door_close_down()
        {
            reader.Speak("Doors are closing");
            insertdata("Doors are Closing in Ground Floor");
            timer_door_close_down.Enabled = true;
            timer_door_open_down.Enabled = false;
        }

        private void door_open_down()
        {
            reader.Speak("Ground floor, doors are open ing");
            insertdata("Doors are Opening in Ground Floor");
            timer_door_close_down.Enabled = false;
            timer_door_open_down.Enabled = true;
        }

        private void door_close_up()
        {
            reader.Speak("doors are closing");
            insertdata("Doors are Closing in First Floor");
            timer_door_close_up.Enabled = true;
            timer_door_open_up.Enabled = false;
        }

        private void door_open_up()
        {
            reader.Speak("First floor , doors are open ing");
            insertdata("Doors are Opening in First Floor");
            timer_door_close_up.Enabled = false;
            timer_door_open_up.Enabled = true;
        }

        //This method will be used 
        private void going_up()
        {
            go_up = true;
            door_close_down();
            btn_G.Enabled = false;
            btn_down.Enabled = false;
            btn_close.Enabled = false;
            btn_open.Enabled = false;
            arrived_G = false;
            insertdata("Elevator is Departing Upstairs   ");

        }

        private void going_down()
        {
            go_down = true;
            door_close_up();

            btn_1.Enabled = false;
            btn_up.Enabled = false;
            btn_close.Enabled = false;
            btn_open.Enabled = false;
            arrived_1 = false;
            insertdata("Elevator is Departing Downstairs");

            
        }






        //This method that calls the above method(i.e. going_down)  
        
        private void btn_down_Click(object sender, EventArgs e)
        {
            btn_up.BackColor = Color.Red;           //This changes the color of downsided button 
            going_up();

        }

        //This method that calls the above method(i.e. going_up)  
        private void btn_up_Click(object sender, EventArgs e)
        {
            btn_down.BackColor = Color.Red;
            going_down();
        }

        //This method that calls the above method(i.e. door_open_down())  
        private void btn_1_Click(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.Red;
            going_up();
        }

        //This method that calls the above method(i.e. ground)  
        private void btn_G_Click(object sender, EventArgs e)
        {
            btn_G.BackColor = Color.OrangeRed;
            going_down();
        }






        private void btn_close_Click(object sender, EventArgs e)
        {
            if (arrived_G == true)
            {
                door_close_down();
            }
            else if (arrived_1 == true)
            {
                door_close_up();
            }

        }


        private void btn_open_Click(object sender, EventArgs e)
        {
            if (arrived_G == true)
            {
                door_open_down();
            }
            else if (arrived_1 == true)
            {
                door_open_up();
            }

        }





        //This method that checks the emergency situation  
        private void btn_alarm_Click(object sender, EventArgs e)
        {
            btn_alarm.BackColor = Color.Green;
            reader.Speak("Emergency !!!!. Elevator has stopped.....please exit carefully.");
            insertdata("Emergency !!!!... Stopped");
            timer_lift_down.Enabled = false;
            timer_lift_up.Enabled = false;
            timer_door_open_down.Enabled = true;
            timer_door_open_up.Enabled = true;
            display_panel.Image = global::ElevatorControl.Properties.Resources.alarmbellbutton;
            display_top.Image = global::ElevatorControl.Properties.Resources.alarmbellbutton;
            display_bottom.Image = global::ElevatorControl.Properties.Resources.alarmbellbutton;

        }

        //Database Connectivity .....This code are used and gives the user the ability to show datas in 
        //Database Variables and instantiations
        private bool filled;
        public DataSet ds = new DataSet();
        


        private void btn_displaylog_Click(object sender, EventArgs e)
        {
            try
            {
                string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ElevatorDatabase.accdb;";
                string dbcommand = "Select * from Actions;";
                OleDbConnection conn = new OleDbConnection(dbconnection);
                OleDbCommand comm = new OleDbCommand(dbcommand, conn);
                OleDbDataAdapter adapter = new OleDbDataAdapter(comm);

                //cnn.Open();
                conn.Open();
                //MessageBox.Show("Connection Open ! ");
                while (filled == false)
                {
                    adapter.Fill(ds);
                    filled = true;
                }
                //cnn.Close();
                conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Can not open connection ! ");
                string message = "Error in connection to datasource";
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            }

            
            //LIve Action is used for showing current status of lift
            LiveAction.Items.Clear();
            {
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    LiveAction.Items.Add(row["Action"] +"\t"+ row["Time"]);
                }


            }

            //ActivityLog is used to save information
            database_listbox.Items.Clear();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                database_listbox.Items.Add(row["Date"] + "\t\t\t\t\t" + row["Time"] + "\t\t" + row["Action"]);
            }

        }

        private void insertdata(string action)
        {
            string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = ElevatorDatabase.accdb;";
            string dbcommand = "insert into [Actions] ([Date],[Time],[Action]) values (@date, @time, @action)";
            string date = DateTime.Now.ToShortDateString();
            string time = DateTime.Now.ToLongTimeString();
        

            database_listbox.Items.Add(date + "\t\t" + time + "\t\t" + action);
            
            LiveAction.Items.Add(action + "\t\t" + time);


            OleDbConnection conn_db = new OleDbConnection(dbconnection);
            OleDbCommand comm_insert = new OleDbCommand(dbcommand, conn_db);
            OleDbDataAdapter adapter_insert = new OleDbDataAdapter(comm_insert);
            comm_insert.Parameters.AddWithValue("@date", date);
            comm_insert.Parameters.AddWithValue("@time", time);
            comm_insert.Parameters.AddWithValue("@action", action);




            conn_db.Open();

            comm_insert.ExecuteNonQuery();

            conn_db.Close();
        }

        private void btn_clearlog_Click(object sender, EventArgs e)
        {
            database_listbox.Items.Clear();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            database_listbox.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        

        
   

    }
}