/**
*	\file		MainForm.cs
*	\author		Mustafa Kemal GILOR <mustafagilor@gmail.com>
*	\date		24/06/2014 17:42
*	
*	\brief
*	A basic minesweeper game.
*	
*   \copyright
*   Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), 
*   to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, 
*   and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
*   The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
*
*   \disclaimer
*   THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
*   FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
*   LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS 
*   IN THE SOFTWARE.
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mine_Field
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Structs

        enum Type
        {
            CLEAR_AREA = 0,
            REVEALED_AREA = 1,
            MINE_AREA = 2,
            MINED_FLAGGED_AREA = 3,
            CLEAR_FLAGGED_AREA = 4,  
            GENERAL_BUTTON = 5
        }

        struct Area
        {
            public int Width;
            public int Height;
        }
        public static Dictionary<int, Label> CheckButtons = new Dictionary<int, Label>();
        struct Mine
        {
            public static bool GameOver = true;
            /// <summary>
            /// All variables
            /// </summary>
            public static int Count = 10;
            public static int Flags = 0;
            public static int ElapsedTime = 0;
            public static int Points = 0;
            public static int Multiplier = 1;
            public static int MultiTimeout = 0;
            public struct Cell
            {
                public static int Size = 50;
                public static int[] Explosive;
                public static Dictionary<int, Label> Array = new Dictionary<int, Label>();

                public struct Count
                {
                    public static int Field = 0;
                    public static int Row = 0;
                    public static int Column = 0;
                }
            }
            public struct Field
            {
                public static int Width = 1000;
                public static int Height = 1000;
            }

        }

        #endregion

        #region Basic Operations

        /// <summary>
        /// Sets mine field area.
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void SetFieldArea(int width, int height)
        {
            Mine.Field.Width = width;
            Mine.Field.Height = height;
        }
        /// <summary>
        /// Returns size of the mine field.
        /// </summary>
        /// <returns></returns>
        private Area GetFieldArea()
        {
            Area x = new Area();
            x.Width = Mine.Field.Width;
            x.Height = Mine.Field.Height;
            return x;
        }
        /// <summary>
        /// Returns column count of field.
        /// </summary>
        /// <returns></returns>
        private int GetColumnCount()
        {
            return Mine.Cell.Count.Column;
        }
        /// <summary>
        /// Updates the elapsed time label.
        /// </summary>
        public void UpdateElapsedTime(int Seconds)
        {
            char Seperator = ':';
            string Minutes = Convert.ToString(Seconds / 60);
            string Secondz = Convert.ToString(Seconds % 60);
            lblTime.Text = Minutes + Seperator + Secondz;
        }

        #endregion

        #region Events

        private void HideGamePanels()
        {
            LeftPanel.Visible = false;
            RightPanel.Visible = false;
        }
        private void ShowGamePanels()
        {
            LeftPanel.Visible = true;
            RightPanel.Visible = true;
        }
        private void HideControls()
        {
            //btnNewGame.Visible = false;
            chbBeginner.Visible = false;
            chbCustom.Visible = false;
            chbExpert.Visible = false;
            chbIntermediate.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            mfHeight.Visible = false;
            mfMineCount.Visible = false;
            mfWidth.Visible = false;
        }
        private void ShowControls()
        {
            btnNewGame.Visible = true;
            chbBeginner.Visible = true;
            chbCustom.Visible = true;
            chbExpert.Visible = true;
            chbIntermediate.Visible = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.SuspendLayout();
            MineField.Visible = false;
            ResetVariables();
            HideGamePanels();
            string name = "";
            Mine.GameOver = true;
            tmrElapsed.Enabled = false;
            tmrElapsed.Stop();
            Mine.ElapsedTime = 0;

            while (MineField.Controls.Count > 0)
            {
                foreach (Control x in MineField.Controls)
                {
                    x.Dispose();
                }
            }
            foreach (KeyValuePair<int, Label> x in CheckButtons)
            {
                if (x.Value.Tag.ToString() == "1")
                    name = x.Value.Name;
            }
            switch (name)
            {
                case "chbBeginner":
                    CreateMineField(500, 500, 15);
                    break;
                case "chbIntermediate":
                    CreateMineField(500, 500, 25);
                    break;
                case "chbExpert":
                    CreateMineField(500, 500, 35);
                    break;
                case "chbCustom":
                    CreateMineField((int)mfWidth.Value, (int)mfHeight.Value, (int)mfMineCount.Value);
                    break;
            }
            tmrElapsed.Enabled = true;
            tmrElapsed.Start();
            Mine.GameOver = false;
        }

        private void FieldRightClickEvent(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (!Mine.GameOver)
                {
                    var myControl = sender as Label;
                    if (e.Button == MouseButtons.Right)
                    {
                        switch ((Type)myControl.Tag)
                        {
                            case Type.CLEAR_AREA:
                                if (UseFlags())
                                {
                                    myControl.ImageIndex = 6;
                                    myControl.Tag = Type.CLEAR_FLAGGED_AREA;
                                    UpdateFlags();
                                }
                                break;
                            case Type.MINE_AREA:
                                if (UseFlags())
                                {
                                    myControl.ImageIndex = 6;
                                    myControl.Tag = Type.MINED_FLAGGED_AREA;
                                    UpdateFlags();
                                }
                                break;
                            case Type.CLEAR_FLAGGED_AREA:
                                myControl.ImageIndex = 0;
                                myControl.Tag = Type.CLEAR_AREA;
                                RecoverFlags();
                                UpdateFlags();
                                break;
                            case Type.MINED_FLAGGED_AREA:
                                myControl.ImageIndex = 0;
                                myControl.Tag = Type.MINE_AREA;
                                RecoverFlags();
                                UpdateFlags();
                                break;
                        }
                    }
                }
            }
            if (e.Button == MouseButtons.Left)
            {
                if (!Mine.GameOver)
                {
                    var myControl = sender as Label;
                    switch ((Type)myControl.Tag)
                    {
                        case Type.CLEAR_AREA:
                            int MineCount = CalculateMinesInRadius(GetFieldNo(myControl.Name), Mine.Cell.Count.Column);
                            if (MineCount != 0)
                            {
                                myControl.Text = MineCount.ToString();
                            }
                            myControl.ForeColor = DetermineFieldNumColor(MineCount);
                            myControl.Tag = Type.REVEALED_AREA;
                            myControl.ImageIndex = 3;
                            GiveRevealPoints(MineCount);
                            AutoExpand(GetFieldNo(myControl.Name));
                            break;
                        case Type.MINE_AREA:
                            foreach (KeyValuePair<int, Label> x in Mine.Cell.Array)
                            {
                                foreach (int n in Mine.Cell.Explosive)
                                {
                                    if (x.Key == n)
                                        x.Value.ImageIndex = 9;
                                }
                            }
                            Mine.GameOver = true;
                            tmrElapsed.Stop();
                            tmrElapsed.Enabled = false;
                            break;
                        case Type.REVEALED_AREA:
                        case Type.MINED_FLAGGED_AREA:
                        case Type.CLEAR_FLAGGED_AREA:
                            break;
                    }
                }
            }
        }



        private void GeneralMouseEnterEvent(object sender, EventArgs e)
        {
            if (!Mine.GameOver)
            {
                var myControl = sender as Label;
                switch ((Type)myControl.Tag)
                {
                    case Type.REVEALED_AREA:
                        myControl.ImageIndex = 3;
                        break;
                    case Type.CLEAR_FLAGGED_AREA:
                    case Type.MINED_FLAGGED_AREA:
                        break;
                    default:
                        myControl.ImageIndex = 1;
                        break;
                }
            }
        }

        private void GeneralMouseLeaveEvent(object sender, EventArgs e)
        {
            if (!Mine.GameOver)
            {
                var myControl = sender as Label;
                switch ((Type)myControl.Tag)
                {
                    case Type.REVEALED_AREA:
                        myControl.ImageIndex = 3;
                        break;
                    case Type.CLEAR_FLAGGED_AREA:
                    case Type.MINED_FLAGGED_AREA:
                        break;
                    default:
                        myControl.ImageIndex = 0;
                        break;
                }
            }
        }
        private void GeneralMouseDownEvent(object sender, MouseEventArgs e)
        {
            if (!Mine.GameOver)
            {
                var myControl = sender as Label;
                switch ((Type)myControl.Tag)
                {
                    case Type.REVEALED_AREA:
                        myControl.ImageIndex = 3;
                        break;
                    case Type.CLEAR_FLAGGED_AREA:
                    case Type.MINED_FLAGGED_AREA:
                        break;
                    default:
                        myControl.ImageIndex = 2;
                        break;
                }
            }
        }
        private void GeneralMouseUpEvent(object sender, MouseEventArgs e)
        {
            if (!Mine.GameOver)
            {
                var myControl = sender as Label;
                switch ((Type)myControl.Tag)
                {
                    case Type.REVEALED_AREA:
                        myControl.ImageIndex = 3;
                        break;
                    case Type.CLEAR_FLAGGED_AREA:
                    case Type.MINED_FLAGGED_AREA:
                        break;
                    default:
                        myControl.ImageIndex = 1;
                        break;
                }
            }
                
        }
        private void CheckButtonClickEvent(object sender, EventArgs e)
        {
            var myControl = sender as Label;
            foreach (KeyValuePair<int, Label> x in CheckButtons)
            {
                x.Value.Tag = 0;
                x.Value.ImageIndex = 0;
            }
            if (myControl.Name == "chbCustom")
            {
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                mfHeight.Visible = true;
                mfMineCount.Visible = true;
                mfWidth.Visible = true;
            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                mfHeight.Visible = false;
                mfMineCount.Visible = false;
                mfWidth.Visible = false;
            }
            myControl.Tag = 1;
            myControl.ImageIndex = 3;
        }

        #endregion

        #region Functions
        /// <summary>
        /// Resets all variables.
        /// </summary>
        private void ResetVariables()
        {
            Mine.Count = 0;
            Mine.Flags = 0;
            Mine.Multiplier = 1;
            Mine.Points = 0;
            Mine.ElapsedTime = 0;
            UpdateFlags();
            UpdateMultiplier();
            UpdatePoints();
        }
        /// <summary>
        /// Updates the multiplier label.
        /// </summary>
        private void UpdateMultiplier()
        {
            lblMulti.Text = "x" + Mine.Multiplier;
        }
        /// <summary>
        /// Decreases the multiplier by 1.
        /// </summary>
        /// <returns></returns>
        private bool DecreaseMultiplier()
        {
            if (Mine.Multiplier > 1)
            {
                Mine.Multiplier--;
                UpdateMultiplier();
                return true;
            }
            return false;
        }
        /// <summary>
        /// Increases the multiplier by 1.
        /// </summary>
        /// <returns></returns>
        private bool IncreaseMultiplier()
        {
            if (Mine.Multiplier <= 7)
            {
                Mine.Multiplier++;
                UpdateMultiplier();
                lblMulti.Location = new Point(0, lblMulti.Location.Y);
               
                lblMultiSec.Visible = true;
                tmrMulti.Start();
                tmrMulti.Enabled = true;
                return true;
            }
            //x8 is the max multiplier
            return false;
        }
        /// <summary>
        /// Gives points to a successful reveal.
        /// </summary>
        /// <param name="refer"></param>
        private void GiveRevealPoints(int refer)
        {
            switch (refer)
            {
                case 1:
                    GivePoints(15);
                    break;
                case 2:
                    GivePoints(17*refer);
                    break;
                case 3:
                    GivePoints(22*refer);
                    break;
                case 4:
                    GivePoints(26*refer);
                    break;
                case 5:
                    GivePoints(33*refer);
                    break;
                case 6:
                    GivePoints(45*refer);
                    break;
                case 7:
                    GivePoints(65*refer);
                    break;
                case 8:
                    GivePoints(90*refer);
                    break;
            }
        }
        /// <summary>
        /// Gives point to the user.
        /// </summary>
        /// <param name="amount"></param>
        private void GivePoints(int amount)
        {
            Mine.Points += amount * Mine.Multiplier;
            UpdatePoints();
        }
        /// <summary>
        /// Updates the points label.
        /// </summary>
        private void UpdatePoints()
        {
            lblPoints.Text = Mine.Points.ToString();
        }
        /// <summary>
        /// Updates the flags label.
        /// </summary>
        private void UpdateFlags()
        {
            lblFlags.Text = Mine.Flags.ToString();
        }
        /// <summary>
        /// Sets the flag count to specified amount.
        /// </summary>
        /// <param name="count"></param>
        private void SetFlags(int count)
        {
            Mine.Flags = count;
        }
        /// <summary>
        /// Tries to use one flag, if exists.
        /// </summary>
        /// <returns></returns>
        private bool UseFlags()
        {
            if (Mine.Flags > 0)
            {
                Mine.Flags--;
                UpdateFlags();
                return true;
            }
            else
            {
                return false;
            }
        }
        private void RecoverFlags()
        {
            Mine.Flags++;
            UpdateFlags();
        }
        /// <summary>
        /// Calculates mine count in field's radius.
        /// </summary>
        /// <param name="FieldNo"></param>
        /// <param name="ColumnCount"></param>
        /// <returns>Integer value</returns>
        private int CalculateMinesInRadius(int FieldNo, int ColumnCount)
        {
            int MineCount = 0;
            int[] Radius = new int[8];
            Radius[0] = FieldNo - ColumnCount;
            Radius[1] = FieldNo - (ColumnCount + 1);
            Radius[2] = FieldNo - (ColumnCount - 1);
            Radius[3] = FieldNo + 1;
            Radius[4] = FieldNo - 1;
            Radius[5] = FieldNo + ColumnCount;
            Radius[6] = FieldNo + (ColumnCount + 1);
            Radius[7] = FieldNo + (ColumnCount - 1);
            try
            {
                foreach (int o in Radius)
                {
                    if ((Type)Mine.Cell.Array[o].Tag == Type.MINE_AREA || (Type)Mine.Cell.Array[o].Tag == Type.MINED_FLAGGED_AREA)
                        MineCount++;
                }
            }
            catch
            {
            }

            return MineCount;
        }
        /// <summary>
        /// Finds field no from FieldName value.
        /// </summary>
        /// <param name="FieldName"></param>
        /// <returns></returns>
        private int GetFieldNo(string FieldName)
        {
            foreach (KeyValuePair<int, Label> y in Mine.Cell.Array)
            {
                if (y.Value.Name == FieldName)
                    return y.Key;
            }
            return -1;
        }
        /// <summary>
        /// Returns button variable of the specified field.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="field2"></param>
        /// <returns></returns>
        private Label GetField(int index)
        {
            if (index > 0 && index < Mine.Cell.Array.Count)
                return Mine.Cell.Array[index];
            else
                return null;
        }
        /// <summary>
        /// Checks if two fields are touching to each other.
        /// </summary>
        /// <param name="referance"></param>
        /// <returns></returns>
        private bool IsTouchingToEachOther(int reference, int field2)
        {
            if (field2 == reference + 1 || field2 == reference - 1 || field2 == reference - Mine.Cell.Count.Column || field2 == reference + Mine.Cell.Count.Column || field2 == reference + Mine.Cell.Count.Column + 1 || field2 == reference + Mine.Cell.Count.Column - 1 || field2 == reference - Mine.Cell.Count.Column - 1 || field2 == reference - Mine.Cell.Count.Column + 1)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Returns all mines' index no's in specified field's radius.
        /// </summary>
        /// <param name="referance"></param>
        /// <returns></returns>
        private Dictionary<int, int> MineStatusInRadius(int referance)
        {
            Dictionary<int, int> Temp = new Dictionary<int, int>();
            Temp.Add(referance - Mine.Cell.Count.Column, 0);
            Temp.Add(referance - Mine.Cell.Count.Column + 1, 0);
            Temp.Add(referance - Mine.Cell.Count.Column - 1, 0);
            Temp.Add(referance - 1, 0);
            Temp.Add(referance + 1, 0);
            Temp.Add(referance + Mine.Cell.Count.Column, 0);
            Temp.Add(referance + Mine.Cell.Count.Column + 1, 0);
            Temp.Add(referance + Mine.Cell.Count.Column - 1, 0);
            try
            {
                foreach (KeyValuePair<int, int> x in Temp)
                {
                    if ((Type)Mine.Cell.Array[x.Key].Tag == Type.MINE_AREA || (Type)Mine.Cell.Array[x.Key].Tag == Type.MINED_FLAGGED_AREA)
                        Temp[x.Key] = 1;

                }
                return Temp;
            }
            catch
            {
            }

            return Temp;
        }
        /// <summary>
        /// Automatically expands mine field if the field is zero.
        /// </summary>
        /// <param name="reference"></param>
        /// <param name="ColumnCount"></param>
        private void AutoExpand(int reference)
        {
            int ColumnCount = GetColumnCount();
            if (CalculateMinesInRadius(reference, ColumnCount) == 0)
            {
                int[] Radius = new int[8];
                Dictionary<int, int> ExpandList = new Dictionary<int, int>();
                Dictionary<int, int> ExpandList2 = new Dictionary<int, int>();
                Radius[0] = reference - ColumnCount;
                Radius[1] = reference - (ColumnCount + 1);
                Radius[2] = reference - (ColumnCount - 1);
                Radius[3] = reference + 1;
                Radius[4] = reference - 1;
                Radius[5] = reference + ColumnCount;
                Radius[6] = reference + (ColumnCount + 1);
                Radius[7] = reference + (ColumnCount - 1);

                foreach (int nfield in Radius)
                {
                    if (CalculateMinesInRadius(nfield, ColumnCount) == 0 && !MineCheck(nfield))
                    {
                        ExpandList.Add(ExpandList.Count + 1, nfield);
                        IncreaseMultiplier();
                        GivePoints(1000);
                    }
                    
                }
                foreach (KeyValuePair<int, int> y in ExpandList)
                {
                    Dictionary<int, int> t = MineStatusInRadius(y.Value);
                    foreach (KeyValuePair<int, int> x in t)
                    {
                        if (x.Value == 0)
                            ExpandList2.Add(ExpandList2.Count + 1, x.Key);
                    }
                }
                foreach (KeyValuePair<int, int> q in ExpandList)
                {
                    ExpandArea(q.Value);
                }
                foreach (KeyValuePair<int, int> q in ExpandList2)
                {
                    ExpandArea(q.Value);
                }
                GivePoints(75 * ExpandList.Count);
                GivePoints(50 * ExpandList2.Count);
            }
        }
        
        /// <summary>
        /// Expands specified field.
        /// </summary>
        /// <param name="reference"></param>
        private void ExpandArea(int reference)
        {
            Label Temp = GetField(reference);

            if (Temp != null)
            {
                if ((Type)Temp.Tag != Type.MINED_FLAGGED_AREA && (Type)Temp.Tag != Type.CLEAR_FLAGGED_AREA)
                {
                    int MineCount = CalculateMinesInRadius(GetFieldNo(Temp.Name), Mine.Cell.Count.Column);
                    if (MineCount != 0)
                        Temp.Text = MineCount.ToString();
                    Temp.ForeColor = DetermineFieldNumColor(MineCount);
                    Temp.Tag = Type.REVEALED_AREA;
                    Temp.ImageIndex = 3;
                }
            }
        }
        /// <summary>
        /// Checks if there is a mine exists in specified field.
        /// </summary>
        /// <param name="reference"></param>
        /// <returns></returns>
        private bool MineCheck(int reference)
        {
            try
            {
                if ((Type)Mine.Cell.Array[reference].Tag == Type.MINE_AREA || (Type)Mine.Cell.Array[reference].Tag == Type.MINED_FLAGGED_AREA)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        private Color DetermineFieldNumColor(int value)
        {
            switch (value)
            {
                case 1:
                    return Color.LimeGreen;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Cyan;
                case 4:
                    return Color.Blue;
                case 5:
                    return Color.Yellow;
                case 6:
                    return Color.Gold;
                case 7:
                    return Color.DarkOrange;
                case 8:
                    return Color.Red;
            }
            return Color.White;
        }
        private Label CreateField(int num,int index,int row)
        {
            Label Temp = new Label();
            Temp.Size = new Size(Mine.Cell.Size, Mine.Cell.Size);
            Temp.Location = new Point(index * Mine.Cell.Size, row * Mine.Cell.Size);
            Temp.Tag = Type.CLEAR_AREA;
            Temp.ImageList = imageListSquareBtn;
            Temp.ImageIndex = 0;
            Temp.TextAlign = ContentAlignment.MiddleCenter;
            Temp.MouseDown += new MouseEventHandler(GeneralMouseDownEvent);
            Temp.MouseUp += new MouseEventHandler(GeneralMouseUpEvent);
            Temp.MouseEnter += new EventHandler(GeneralMouseEnterEvent);
            Temp.MouseLeave += new EventHandler(GeneralMouseLeaveEvent);
            Temp.ImageAlign = ContentAlignment.MiddleCenter;
            Temp.MouseDown += new MouseEventHandler(FieldRightClickEvent);
            Temp.Name = "FieldBox" + num;
            Font x = new Font("Stencil",16.0F);
            Temp.Font = x;
            return Temp;
        }
        private void MoveField(int num, int interval)
        {
        }

        /// <summary>
        /// Mine field create method. Creates a mine field in respect to specified parameters.
        /// </summary>
        /// <param name="Width">Width of the mine field</param>
        /// <param name="Height">Height of the mine field</param>
        /// <param name="MineCount">Mine count</param>
        private void CreateMineField(int Width, int Height, int MineCount)
        {
            foreach (KeyValuePair<int, Label> x in Mine.Cell.Array)
            {
                x.Value.Dispose();
            }
            Mine.Cell.Array.Clear();
            Random Generate = new Random();
            MineField.Width = Width;
            MineField.Height = Height;
            MineField.Location = new Point((this.Size.Width - Width) / 2, topbox.Height);
            this.Size = new Size(Width, Height);
            //Calculate maximum field count
            int Area = Width * Height;
            int BoxCount = Area / (Mine.Cell.Size * Mine.Cell.Size);
            int ColumnCount = Width / Mine.Cell.Size;
            Mine.Cell.Count.Column = ColumnCount;
            int RowCount = Height / Mine.Cell.Size;
            int Row = 0, Index = 0;
            //set label
            
            for (int i = 0; i < BoxCount; i++)
            {
                Mine.Cell.Array.Add(i, CreateField(i,Index,Row));
                MineField.Controls.Add(Mine.Cell.Array[i]);
                if (Index == ColumnCount - 1)
                {
                    Row++;
                    Index = 0;
                }
                else
                {
                    Index++;
                }
            }
            this.ResumeLayout();
            int[] LuckyOnes = new int[MineCount];
            for (int i = 0; i < MineCount; i++)
            {
                LuckyOnes[i] = Generate.Next(0, BoxCount);
            }
            Mine.Cell.Explosive = LuckyOnes;
            foreach (KeyValuePair<int, Label> x in Mine.Cell.Array)
            {
                foreach (int y in LuckyOnes)
                {
                    if (x.Key == y)
                    {
                        x.Value.Tag = Type.MINE_AREA;
                    }
                }
            }
            SetFlags(MineCount);
            UpdateFlags();
            HideControls();
            MineField.Visible = true;
            ShowGamePanels();
        }

        #endregion


















        /*  private int AutoExpand(int ReferanceField) 
        {
            if (50 == 50)
            {
            }
        }*/





        private void Form1_Load(object sender, EventArgs e)
        {

            topbox.Location = new Point(0, 0);
            CheckButtons.Add(CheckButtons.Count + 1, chbBeginner);
            CheckButtons.Add(CheckButtons.Count + 1, chbIntermediate);
            CheckButtons.Add(CheckButtons.Count + 1, chbExpert);
            CheckButtons.Add(CheckButtons.Count + 1, chbCustom);
            btnNewGame.Tag = Type.GENERAL_BUTTON;
            foreach (KeyValuePair<int, Label> x in CheckButtons)
            {
                x.Value.Tag = Type.GENERAL_BUTTON;
            }


        }

        private void MineField_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void tmrElapsed_Tick(object sender, EventArgs e)
        {
            UpdateElapsedTime(Mine.ElapsedTime);
            Mine.ElapsedTime++;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(MineField.Height >= this.Height)
            {
                MineField.Location = new Point((this.Width / 2) - MineField.Width / 2, MineField.Height / 2 + topbox.Height);
            }
            else
            {
            MineField.Location = new Point((this.Width / 2) - MineField.Width / 2, ((this.Height / 2) - MineField.Height / 2) + topbox.Height/2);
            }
            topbox.Location = new Point((this.Width / 2) - topbox.Width / 2, topbox.Location.Y);
           
        }

        private void tmrMulti_Tick(object sender, EventArgs e)
        {
            if (Mine.Multiplier > 1 && Mine.MultiTimeout == 0)
            {
                DecreaseMultiplier();
                Mine.MultiTimeout = 8;
            }
            if (Mine.Multiplier == 1)
            {
                lblMultiSec.Text = "∞";
                lblMulti.Location = new Point(17, lblMulti.Location.Y);
                lblMultiSec.Visible = false;
                tmrMulti.Stop();
                tmrMulti.Enabled = false;
            }
            lblMultiSec.Text = Mine.MultiTimeout.ToString();
            Mine.MultiTimeout--;

        }



        
    }
}
