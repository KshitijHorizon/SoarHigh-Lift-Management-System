namespace ElevatorControl
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer_lift_down = new System.Windows.Forms.Timer(this.components);
            this.timer_lift_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_down = new System.Windows.Forms.Timer(this.components);
            this.timer_door_open_up = new System.Windows.Forms.Timer(this.components);
            this.timer_door_close_up = new System.Windows.Forms.Timer(this.components);
            this.database_listbox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LiveAction = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.door_right_up = new System.Windows.Forms.PictureBox();
            this.door_left_up = new System.Windows.Forms.PictureBox();
            this.door_left_down = new System.Windows.Forms.PictureBox();
            this.door_right_down = new System.Windows.Forms.PictureBox();
            this.btn_alarm = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_G = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.display_bottom = new System.Windows.Forms.PictureBox();
            this.display_panel = new System.Windows.Forms.PictureBox();
            this.display_top = new System.Windows.Forms.PictureBox();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.bg_panel = new System.Windows.Forms.PictureBox();
            this.picture_lift = new System.Windows.Forms.PictureBox();
            this.bg_firstfloor = new System.Windows.Forms.PictureBox();
            this.bg_groundfloor = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btn_displaylog = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_panel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_firstfloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_groundfloor)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_lift_down
            // 
            this.timer_lift_down.Interval = 15;
            this.timer_lift_down.Tick += new System.EventHandler(this.timer_lift_down_Tick);
            // 
            // timer_lift_up
            // 
            this.timer_lift_up.Interval = 15;
            this.timer_lift_up.Tick += new System.EventHandler(this.timer_lift_up_Tick);
            // 
            // timer_door_open_down
            // 
            this.timer_door_open_down.Interval = 5;
            this.timer_door_open_down.Tick += new System.EventHandler(this.door_open_down_Tick);
            // 
            // timer_door_close_down
            // 
            this.timer_door_close_down.Interval = 5;
            this.timer_door_close_down.Tick += new System.EventHandler(this.door_close_down_Tick);
            // 
            // timer_door_open_up
            // 
            this.timer_door_open_up.Interval = 5;
            this.timer_door_open_up.Tick += new System.EventHandler(this.timer_door_open_up_Tick);
            // 
            // timer_door_close_up
            // 
            this.timer_door_close_up.Interval = 5;
            this.timer_door_close_up.Tick += new System.EventHandler(this.timer_door_close_up_Tick);
            // 
            // database_listbox
            // 
            this.database_listbox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.database_listbox.Font = new System.Drawing.Font("Open Sans Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.database_listbox.FormattingEnabled = true;
            this.database_listbox.ItemHeight = 17;
            this.database_listbox.Location = new System.Drawing.Point(432, 377);
            this.database_listbox.Name = "database_listbox";
            this.database_listbox.Size = new System.Drawing.Size(507, 242);
            this.database_listbox.TabIndex = 20;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(637, 641);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 33);
            this.button2.TabIndex = 70;
            this.button2.Text = "Clear Log";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(811, 641);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 33);
            this.button3.TabIndex = 71;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LiveAction
            // 
            this.LiveAction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.LiveAction.Font = new System.Drawing.Font("Open Sans Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LiveAction.ForeColor = System.Drawing.Color.Black;
            this.LiveAction.FormattingEnabled = true;
            this.LiveAction.ItemHeight = 18;
            this.LiveAction.Location = new System.Drawing.Point(432, 99);
            this.LiveAction.Name = "LiveAction";
            this.LiveAction.Size = new System.Drawing.Size(507, 202);
            this.LiveAction.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(634, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 22);
            this.label2.TabIndex = 73;
            this.label2.Text = "Live Action";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(632, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 74;
            this.label3.Text = "Activity Log";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox3.Image = global::ElevatorControl.Properties.Resources.Icon1;
            this.pictureBox3.Location = new System.Drawing.Point(105, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(61, 55);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 75;
            this.pictureBox3.TabStop = false;
            // 
            // door_right_up
            // 
            this.door_right_up.Image = global::ElevatorControl.Properties.Resources.lift_door_right1;
            this.door_right_up.Location = new System.Drawing.Point(140, 124);
            this.door_right_up.Name = "door_right_up";
            this.door_right_up.Size = new System.Drawing.Size(65, 196);
            this.door_right_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_right_up.TabIndex = 19;
            this.door_right_up.TabStop = false;
            // 
            // door_left_up
            // 
            this.door_left_up.BackColor = System.Drawing.SystemColors.Control;
            this.door_left_up.Image = global::ElevatorControl.Properties.Resources.lift_door_left1;
            this.door_left_up.Location = new System.Drawing.Point(75, 124);
            this.door_left_up.Name = "door_left_up";
            this.door_left_up.Size = new System.Drawing.Size(66, 196);
            this.door_left_up.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_left_up.TabIndex = 18;
            this.door_left_up.TabStop = false;
            // 
            // door_left_down
            // 
            this.door_left_down.BackColor = System.Drawing.SystemColors.Control;
            this.door_left_down.Image = global::ElevatorControl.Properties.Resources.lift_door_left1;
            this.door_left_down.Location = new System.Drawing.Point(76, 442);
            this.door_left_down.Name = "door_left_down";
            this.door_left_down.Size = new System.Drawing.Size(66, 196);
            this.door_left_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_left_down.TabIndex = 16;
            this.door_left_down.TabStop = false;
            // 
            // door_right_down
            // 
            this.door_right_down.Image = global::ElevatorControl.Properties.Resources.lift_door_right1;
            this.door_right_down.Location = new System.Drawing.Point(140, 442);
            this.door_right_down.Name = "door_right_down";
            this.door_right_down.Size = new System.Drawing.Size(65, 196);
            this.door_right_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.door_right_down.TabIndex = 17;
            this.door_right_down.TabStop = false;
            // 
            // btn_alarm
            // 
            this.btn_alarm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_alarm.BackgroundImage")));
            this.btn_alarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_alarm.Location = new System.Drawing.Point(311, 611);
            this.btn_alarm.Name = "btn_alarm";
            this.btn_alarm.Size = new System.Drawing.Size(45, 45);
            this.btn_alarm.TabIndex = 15;
            this.btn_alarm.UseVisualStyleBackColor = true;
            this.btn_alarm.Click += new System.EventHandler(this.btn_alarm_Click);
            // 
            // btn_open
            // 
            this.btn_open.BackColor = System.Drawing.Color.White;
            this.btn_open.BackgroundImage = global::ElevatorControl.Properties.Resources.opendoorbutton;
            this.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_open.Location = new System.Drawing.Point(338, 513);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(52, 52);
            this.btn_open.TabIndex = 14;
            this.btn_open.UseVisualStyleBackColor = false;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.White;
            this.btn_close.BackgroundImage = global::ElevatorControl.Properties.Resources.closedoorsbutton;
            this.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_close.Location = new System.Drawing.Point(278, 513);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(52, 52);
            this.btn_close.TabIndex = 13;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_G
            // 
            this.btn_G.BackColor = System.Drawing.Color.White;
            this.btn_G.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_G.BackgroundImage")));
            this.btn_G.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_G.Location = new System.Drawing.Point(298, 396);
            this.btn_G.Name = "btn_G";
            this.btn_G.Size = new System.Drawing.Size(72, 65);
            this.btn_G.TabIndex = 12;
            this.btn_G.UseVisualStyleBackColor = false;
            this.btn_G.Click += new System.EventHandler(this.btn_G_Click);
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.White;
            this.btn_1.BackgroundImage = global::ElevatorControl.Properties.Resources.firstfloorbutton2;
            this.btn_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_1.Location = new System.Drawing.Point(299, 272);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(72, 65);
            this.btn_1.TabIndex = 11;
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // display_bottom
            // 
            this.display_bottom.BackColor = System.Drawing.Color.Transparent;
            this.display_bottom.BackgroundImage = global::ElevatorControl.Properties.Resources.black;
            this.display_bottom.Location = new System.Drawing.Point(132, 406);
            this.display_bottom.Name = "display_bottom";
            this.display_bottom.Size = new System.Drawing.Size(13, 14);
            this.display_bottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_bottom.TabIndex = 9;
            this.display_bottom.TabStop = false;
            // 
            // display_panel
            // 
            this.display_panel.BackColor = System.Drawing.Color.Black;
            this.display_panel.BackgroundImage = global::ElevatorControl.Properties.Resources.black;
            this.display_panel.Location = new System.Drawing.Point(299, 149);
            this.display_panel.Name = "display_panel";
            this.display_panel.Size = new System.Drawing.Size(72, 74);
            this.display_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_panel.TabIndex = 10;
            this.display_panel.TabStop = false;
            // 
            // display_top
            // 
            this.display_top.BackColor = System.Drawing.Color.Black;
            this.display_top.BackgroundImage = global::ElevatorControl.Properties.Resources.black;
            this.display_top.Location = new System.Drawing.Point(132, 88);
            this.display_top.Name = "display_top";
            this.display_top.Size = new System.Drawing.Size(13, 14);
            this.display_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.display_top.TabIndex = 8;
            this.display_top.TabStop = false;
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Transparent;
            this.btn_down.BackgroundImage = global::ElevatorControl.Properties.Resources.direction_north1;
            this.btn_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_down.Location = new System.Drawing.Point(223, 513);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(40, 39);
            this.btn_down.TabIndex = 7;
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Transparent;
            this.btn_up.BackgroundImage = global::ElevatorControl.Properties.Resources.direction_south2;
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_up.Location = new System.Drawing.Point(223, 224);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(40, 39);
            this.btn_up.TabIndex = 6;
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_down_Click);
            // 
            // bg_panel
            // 
            this.bg_panel.Image = global::ElevatorControl.Properties.Resources.controlpanel;
            this.bg_panel.Location = new System.Drawing.Point(278, 60);
            this.bg_panel.Name = "bg_panel";
            this.bg_panel.Size = new System.Drawing.Size(126, 633);
            this.bg_panel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bg_panel.TabIndex = 4;
            this.bg_panel.TabStop = false;
            // 
            // picture_lift
            // 
            this.picture_lift.BackColor = System.Drawing.Color.Transparent;
            this.picture_lift.Image = global::ElevatorControl.Properties.Resources.Inside_of_the_lift;
            this.picture_lift.Location = new System.Drawing.Point(73, 124);
            this.picture_lift.Name = "picture_lift";
            this.picture_lift.Size = new System.Drawing.Size(130, 197);
            this.picture_lift.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_lift.TabIndex = 3;
            this.picture_lift.TabStop = false;
            // 
            // bg_firstfloor
            // 
            this.bg_firstfloor.BackColor = System.Drawing.Color.Transparent;
            this.bg_firstfloor.Image = global::ElevatorControl.Properties.Resources.First_Floor1;
            this.bg_firstfloor.Location = new System.Drawing.Point(-2, 61);
            this.bg_firstfloor.Name = "bg_firstfloor";
            this.bg_firstfloor.Size = new System.Drawing.Size(282, 317);
            this.bg_firstfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg_firstfloor.TabIndex = 0;
            this.bg_firstfloor.TabStop = false;
            // 
            // bg_groundfloor
            // 
            this.bg_groundfloor.BackColor = System.Drawing.Color.Transparent;
            this.bg_groundfloor.Image = global::ElevatorControl.Properties.Resources.Ground_Floor__2_;
            this.bg_groundfloor.Location = new System.Drawing.Point(-2, 378);
            this.bg_groundfloor.Name = "bg_groundfloor";
            this.bg_groundfloor.Size = new System.Drawing.Size(281, 317);
            this.bg_groundfloor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bg_groundfloor.TabIndex = 1;
            this.bg_groundfloor.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 33.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(296, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(508, 46);
            this.label1.TabIndex = 76;
            this.label1.Text = "Elevator Controller System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(447, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 77;
            this.label4.Text = "Date";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(573, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 78;
            this.label5.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(783, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 15);
            this.label6.TabIndex = 79;
            this.label6.Text = "LogData";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(959, 686);
            this.shapeContainer1.TabIndex = 80;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 731;
            this.lineShape4.X2 = 924;
            this.lineShape4.Y1 = 84;
            this.lineShape4.Y2 = 84;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 735;
            this.lineShape3.X2 = 923;
            this.lineShape3.Y1 = 341;
            this.lineShape3.Y2 = 341;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 447;
            this.lineShape2.X2 = 625;
            this.lineShape2.Y1 = 340;
            this.lineShape2.Y2 = 340;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 450;
            this.lineShape1.X2 = 628;
            this.lineShape1.Y1 = 83;
            this.lineShape1.Y2 = 83;
            // 
            // btn_displaylog
            // 
            this.btn_displaylog.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_displaylog.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_displaylog.Location = new System.Drawing.Point(454, 641);
            this.btn_displaylog.Name = "btn_displaylog";
            this.btn_displaylog.Size = new System.Drawing.Size(104, 33);
            this.btn_displaylog.TabIndex = 81;
            this.btn_displaylog.Text = "View Log";
            this.btn_displaylog.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "First Floor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 656);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 83;
            this.label8.Text = "Ground Floor";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(959, 686);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_displaylog);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LiveAction);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.door_right_up);
            this.Controls.Add(this.database_listbox);
            this.Controls.Add(this.door_left_up);
            this.Controls.Add(this.door_left_down);
            this.Controls.Add(this.door_right_down);
            this.Controls.Add(this.btn_alarm);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_G);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.display_bottom);
            this.Controls.Add(this.display_panel);
            this.Controls.Add(this.display_top);
            this.Controls.Add(this.btn_down);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.bg_panel);
            this.Controls.Add(this.picture_lift);
            this.Controls.Add(this.bg_firstfloor);
            this.Controls.Add(this.bg_groundfloor);
            this.Controls.Add(this.shapeContainer1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Elevator Controller System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_up)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_left_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.door_right_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_bottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.display_top)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_panel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_lift)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_firstfloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bg_groundfloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bg_firstfloor;
        private System.Windows.Forms.PictureBox bg_groundfloor;
        private System.Windows.Forms.PictureBox picture_lift;
        private System.Windows.Forms.Timer timer_lift_down;
        private System.Windows.Forms.PictureBox bg_panel;
        private System.Windows.Forms.Button btn_up;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Timer timer_lift_up;
        private System.Windows.Forms.PictureBox display_top;
        private System.Windows.Forms.PictureBox display_bottom;
        private System.Windows.Forms.PictureBox display_panel;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_G;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_alarm;
        private System.Windows.Forms.PictureBox door_left_down;
        private System.Windows.Forms.PictureBox door_right_down;
        private System.Windows.Forms.Timer timer_door_open_down;
        private System.Windows.Forms.Timer timer_door_close_down;
        private System.Windows.Forms.PictureBox door_left_up;
        private System.Windows.Forms.PictureBox door_right_up;
        private System.Windows.Forms.Timer timer_door_open_up;
        private System.Windows.Forms.Timer timer_door_close_up;
        private System.Windows.Forms.ListBox database_listbox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox LiveAction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button btn_displaylog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

