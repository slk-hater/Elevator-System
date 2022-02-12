using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace Elevator_System
{
    public partial class ElevatorForm : Form
    {
        /*
         * DECLARATIONS
         */
        readonly bool DEBUG_MODE = true;
        readonly int FLOORS_AMOUNT = 8, SPEED = 8, STOP_TIME = 4;
        int currentFloor = 0, nextFloor = 0, startFloor = 0;
        Directions currentDirection = Directions.INVALID;
        Panel movablePanel;
        Timer movementPanelTmr = new Timer();
        readonly Timer cooldownTmr = new Timer();
        readonly Queue elevatorQueue = new Queue();
        enum Directions
        {
            INVALID,
            UP,
            DOWN
        }


        /*
         * METHODS
         */
        public ElevatorForm(int _floorsAmount, int _speed, int _stopTime)
        {
            InitializeComponent();
            FLOORS_AMOUNT = _floorsAmount;
            SPEED = _speed;
            STOP_TIME = _stopTime;
            cooldownTmr.Interval = 1000;
            CreateFloorsDisplay();
            CreateFloorsRequester();
            UpdateDisplays();
        }
        void CreateFloorsDisplay()
        {
            int _x = 10, _y = 158;
            int _i = FLOORS_AMOUNT - 1;

            for (int i = FLOORS_AMOUNT; i > 0; i--)
            {
                Panel _pnl = new Panel()
                {
                    Name = "panelFloor" + _i.ToString(),
                    Size = new Size(110, 50),
                    Location = new Point(_x, _y),
                    Anchor = AnchorStyles.Left,
                    BackColor = Color.FromArgb(36, 36, 36),
                };
                _i--;
                if (_pnl.Name.Replace("panelFloor", "") == currentFloor.ToString())
                {
                    movablePanel = new Panel()
                    {
                        Size = new Size(110, 50),
                        Location = new Point(_x, _y),
                        Anchor = AnchorStyles.Left,
                        BackColor = Color.FromArgb(176, 176, 176),
                    };
                    Controls.Add(movablePanel);
                    movablePanel.BringToFront();
                }
                Controls.Add(_pnl);
                _y += 56;
            }
        }
        void CreateFloorsRequester()
        {
            int _x = 30, _y = 110;
            int _index = FLOORS_AMOUNT - 1;
            bool _newRow = false;
            for (int i = 0; i < FLOORS_AMOUNT; i++)
            {
                Button _btn = new Button()
                {
                    Name = "lvl" + _index,
                    Text = _index.ToString(),
                    Size = new Size(60, 60),
                    Location = new Point(_x, _y),
                    TextAlign = ContentAlignment.MiddleCenter,
                    BackColor = Color.FromArgb(230, 255, 255),
                    FlatStyle = FlatStyle.Flat,
                    Font = new Font("Arial", 20),
                };
                if (!_newRow && i >= (FLOORS_AMOUNT / 2) - 1)
                {
                    _newRow = true;
                    _x += 80;
                    _y = 40;
                }
                if (_newRow)
                    _btn.Anchor = AnchorStyles.Right;
                else
                    _btn.Anchor = AnchorStyles.Left;
                floorsPanel.Controls.Add(_btn);
                _btn.Click += new EventHandler(CallElevator);
                _y += 70;
                _index--;
            }
        }
        void ChangeDirection(Directions direction)
        {
            //if(DEBUG_MODE && currentDirection != direction)
            //Debug.WriteLine("DIRECTION CHANGED FROM '" + currentDirection + "' TO '" + direction+"'");

            currentDirection = direction;

            Color _toPaint = Color.Black;
            if (currentDirection != Directions.INVALID)
            {
                Bitmap directionArrow = Properties.Resources.arrow_right;
                if (currentDirection == Directions.UP)
                {
                    directionArrow.RotateFlip(RotateFlipType.Rotate90FlipY);
                    _toPaint = Color.FromArgb(17, 204, 29);
                }
                else if (currentDirection == Directions.DOWN)
                {
                    directionArrow.RotateFlip(RotateFlipType.Rotate90FlipX);
                    _toPaint = Color.FromArgb(204, 17, 17);
                }
                for (int x = 0; x < directionArrow.Width; x++)
                    for (int y = 0; y < directionArrow.Height; y++)
                        if (directionArrow.GetPixel(x, y) != Color.FromArgb(0, 0, 0, 0))
                            directionArrow.SetPixel(x, y, _toPaint);
                directionPb.Image = directionArrow;
            }
            else
            {
                directionPb.Image = null;
                _toPaint = Color.FromArgb(204, 17, 17);
            }

            currentFloorLb.ForeColor = _toPaint;
        }
        void SortQueue()
        {
            if (elevatorQueue.Count > 0)
            {
                object _movingTo = elevatorQueue.Peek();
                object[] _queueVals = elevatorQueue.ToArray();

                if ((int)elevatorQueue.Peek() > currentFloor)
                    Array.Sort(_queueVals);
                else
                    Array.Reverse(_queueVals);
                elevatorQueue.Clear();

                bool _removed = false;
                foreach (object _obj in _queueVals)
                {
                    if (!_removed && _obj == _movingTo)
                    {
                        elevatorQueue.Enqueue(_obj);
                    }
                    else
                    {
                        elevatorQueue.Enqueue(_obj);
                        _removed = true;
                    }
                }
            }
        }
        void UpdateDisplays()
        {
            if (currentDirection == Directions.UP)
                ChangeDirection(Directions.UP);
            else if (currentDirection == Directions.DOWN)
                ChangeDirection(Directions.DOWN);
            else if (currentDirection == Directions.INVALID)
                directionPb.Image = null;

            currentFloorLb.Text = currentFloor.ToString();
        }


        /*
         * EVENTS
         */
        void FloorsRequesterBorder(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, floorsPanel.DisplayRectangle, Color.DarkGray, ButtonBorderStyle.Solid);
        }
        void CallElevator(object sender, EventArgs e)
        {
            int _calledFloor = int.Parse(((Button)sender).Text);
            bool _accepted = true;
            if (_calledFloor != currentFloor)
            {
                if (elevatorQueue.Count > 0)
                {
                    if ((int)elevatorQueue.Peek() == _calledFloor) // CANCEL REPEATED REQUESTS
                        _accepted = false;
                }

                if (DEBUG_MODE && _accepted)
                    Debug.WriteLine("CALLED FLOOR '" + _calledFloor + "', ACCEPTED AND ENQUEUED");
                else if (!_accepted)
                    Debug.WriteLine("CALLED FLOOR '" + _calledFloor + "', NOT ACCEPTED");

                if (_accepted)
                {
                    elevatorQueue.Enqueue(_calledFloor);
                    SortQueue();

                    if (!movementPanelTmr.Enabled && !cooldownTmr.Enabled)
                    {
                        startFloor = currentFloor;
                        MoveElevator();
                    }
                }
            }
        }
        void EmergencyStop(object sender, EventArgs e)
        {
            if (movementPanelTmr.Enabled)
            {
                elevatorQueue.Clear();
                ChangeDirection(Directions.INVALID);
                UpdateDisplays();
                Bitmap marks = Properties.Resources.Exclamation_Marks;
                for (int x = 0; x < marks.Width; x++)
                    for (int y = 0; y < marks.Height; y++)
                        if (marks.GetPixel(x, y) != Color.FromArgb(0, 0, 0, 0))
                            marks.SetPixel(x, y, Color.FromArgb(204, 17, 17));
                directionPb.Image = marks;
                movementPanelTmr.Stop();
                cooldownTmr.Stop();
                if (DEBUG_MODE)
                    Debug.WriteLine("\r\nEMERGENCY STOP OCCURRED!!\r\n");
            }
        }
        void MoveElevator()
        {
            if (elevatorQueue.Count > 0)
            {
                int _desiredFloor = (int)elevatorQueue.Peek();
                if (currentFloor != _desiredFloor) // ACCEPTED MOVING THE ELEVATOR
                {
                    if (currentFloor < _desiredFloor)
                        ChangeDirection(Directions.UP);
                    else
                        ChangeDirection(Directions.DOWN);

                    if (!movementPanelTmr.Enabled)
                    {
                        movementPanelTmr = new Timer { Interval = (450 - SPEED * 100) / 5 };
                        movementPanelTmr.Start();
                    }
                    else return;

                    movementPanelTmr.Tick += (senderr, ee) => // MOVING ANIMATION
                    {
                        Panel _nextFloorPanel = new Panel();
                        nextFloor = (int)elevatorQueue.Peek();
                        _nextFloorPanel = (Panel)Controls.Find("panelFloor" + nextFloor.ToString(), true)[0];
                        int _y = movablePanel.Location.Y, _targetY = _nextFloorPanel.Location.Y;

                        movablePanel.BackColor = Color.FromArgb(176, 176, 176);
                        if (currentDirection == Directions.UP)
                            movablePanel.Location = new Point(movablePanel.Location.X, movablePanel.Location.Y - 1);
                        else if (currentDirection == Directions.DOWN)
                            movablePanel.Location = new Point(movablePanel.Location.X, movablePanel.Location.Y + 1);

                        if (_y == _targetY) // REACHED THE DESTINATION FLOOR
                        {
                            movementPanelTmr.Stop();
                            movablePanel.Location = new Point(_nextFloorPanel.Location.X, _nextFloorPanel.Location.Y);
                            movablePanel.BackColor = Color.FromArgb(0, 255, 0);

                            currentFloor = nextFloor;
                            ChangeDirection(Directions.INVALID);
                            if (DEBUG_MODE) Debug.WriteLine("MOVED FROM FLOOR '" + startFloor + "' TO '" + nextFloor + "' AND DEQUEUED");
                            startFloor = currentFloor;
                            elevatorQueue.Dequeue();
                            UpdateDisplays();
                            if (elevatorQueue.Count == 0)
                            {
                                if (DEBUG_MODE) Debug.WriteLine("NO MORE FLOORS TO MOVE, STOPPED ELEVATOR AT FLOOR '" + currentFloor + "'\r\n");
                            }
                            else if (elevatorQueue.Count > 0)
                            {
                                if (DEBUG_MODE) Debug.WriteLine("\r\nSTOPPED TO OPEN DOORS");
                                int _stopTime = 0;
                                cooldownTmr.Start();
                                if (DEBUG_MODE) Debug.Write("WAITED ");
                                cooldownTmr.Tick += (senderrr, eee) =>
                                {
                                    if (_stopTime < STOP_TIME)
                                    {
                                        if (DEBUG_MODE) Debug.Write(_stopTime + "... ");
                                        _stopTime++;
                                        if (_stopTime >= STOP_TIME)
                                        {
                                            if (DEBUG_MODE)
                                            {
                                                Debug.Write(" SECONDS\r\n");
                                                Debug.WriteLine("DOORS CLOSED, MOVING TO NEXT FLOOR");
                                            }
                                            cooldownTmr.Stop();
                                            MoveElevator();
                                        }
                                    }
                                };
                            }
                        }
                        else // CHANGE DISPLAY WHILE MOVING TO CURRENT FLOOR
                        {
                            foreach(Panel pnl in this.Controls) 
                            { 
                                if (pnl.Name.Contains("panelFloor"))
                                {
                                    if(movablePanel.Location.Y == pnl.Location.Y)
                                    {
                                        currentFloor = int.Parse(pnl.Name.Replace("panelFloor", ""));
                                        UpdateDisplays();
                                    }
                                }
                            }
                        }
                    };
                }
            }
        }
    }
}