using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public enum State
    {
        Cross,
        Zero,
        Unset
    }
    
    public enum Winner
    {
        Crosses,
        Zeroes,
        Draw,
        Unfinished
    }
    

    class TicTacToe
    {
        public readonly State[,] Area = new State[3, 3];


        private State[,] ResultArea = new State[3, 3];
        

        int CountSteps = 0;


        public TicTacToe()
        {
            for (int i = 0; i <Area.GetLength(0); i++)
            {
                for (int j = 0; j < Area.GetLength(1); j++)
                {
                    Area[i, j] = State.Unset;
                    ResultArea[i, j] = State.Unset;
                }
            }
        }

        public void Put(int index, int index2)
        {
            Area[index - 1, index2 - 1] = CountSteps % 2 == 0 ? State.Cross : State.Zero;

            CountSteps++;

        }

        public State GetState(int index, int index2)
        {
            return Area[index - 1, index2 - 1];
        }


        public Winner GetWinner()
        {
            for (int i = 0; i < Area.Length; i++)
            {
                State same = Same();
                if (same != State.Unset)
                {
                    return same == State.Cross ? Winner.Crosses : Winner.Zeroes;
                }
            }

            if (CountSteps < 9)
            {
                return Winner.Unfinished;
            }
            return Winner.Draw;
        }
        public State Same()
        {
            Presets presets = new Presets();
            int Count = 0;
            bool CheckSameState()
            {
                for (int i = 0; i < Area.GetLength(0); i++)
                {
                    for (int j = 0; j < Area.GetLength(1); j++)
                    {
                        if (Area[i,j] == presets.area2[i,j] &&  Area[i,j] != State.Unset)
                        {
                            Count++;
                            if (Count == 3)
                            {
                                return true;
                            }
                            else
                            {
                                continue;
                            }
                        }

                    }
                }
                 return false;
            }

            presets.PresetOfCrosses1();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }
            

            presets.PresetOfCrosses2();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfCrosses3();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfCrosses4();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfCrosses5();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfCrosses6();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfCrosses7();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfCrosses8();
            if (CheckSameState())
            {
                return State.Cross;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes1();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes2();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes3();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes4();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes5();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes6();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes7();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            presets.PresetOfZeroes8();
            if (CheckSameState())
            {
                return State.Zero;
            }
            else
            {
                Count = 0;
            }

            return State.Unset;
            
            
            
        }
        
    }

    class Presets
    {
        public readonly State[,] area2 = new State[3, 3];

        void Construct()
        {
            for (int i = 0; i < area2.GetLength(0); i++)
            {
                for (int j = 0; j < area2.GetLength(1); j++)
                {
                    area2[i, j] = State.Unset;
                }
            }
        }
        public Presets()
        {
            Construct();
        }

        #region presetsofCrosses
        public State[,] PresetOfCrosses1()
        {
            
            Construct();
            area2[0, 0] = State.Cross;
            area2[0, 1] = State.Cross;
            area2[0, 2] = State.Cross;

            return area2;
        }
        public State[,] PresetOfCrosses2()
        {
            Construct();
            area2[1, 0] = State.Cross;
            area2[1, 1] = State.Cross;
            area2[1, 2] = State.Cross;

            return area2;
        }
        public State[,] PresetOfCrosses3()
        {
            Construct();
            area2[2, 0] = State.Cross;
            area2[2, 1] = State.Cross;
            area2[2, 2] = State.Cross;

            return area2;
        }
        public State[,] PresetOfCrosses4()
        {
            Construct();
            area2[0, 0] = State.Cross;
            area2[1, 0] = State.Cross;
            area2[2, 0] = State.Cross;

            return area2;
        }

        public State[,] PresetOfCrosses5()
        {
            Construct();
            area2[0, 1] = State.Cross;
            area2[1, 1] = State.Cross;
            area2[2, 1] = State.Cross;

            return area2;
        }

        public State[,] PresetOfCrosses6()
        {
            Construct();
            area2[0, 2] = State.Cross;
            area2[1, 2] = State.Cross;
            area2[2, 2] = State.Cross;

            return area2;
        }
        public State[,] PresetOfCrosses7()
        {
            Construct();
            area2[0, 2] = State.Cross;
            area2[1, 1] = State.Cross;
            area2[2, 0] = State.Cross;

            return area2;
        }

        public State[,] PresetOfCrosses8()
        {
            Construct();
            area2[0, 0] = State.Cross;
            area2[1, 1] = State.Cross;
            area2[2, 2] = State.Cross;

            return area2;
        }
        #endregion

        #region presetsofZeroes
        public State[,] PresetOfZeroes1()
        {
            Construct();
            area2[0, 0] = State.Zero;
            area2[0, 1] = State.Zero;
            area2[0, 2] = State.Zero;

            return area2;
        }

        public State[,] PresetOfZeroes2()
        {
            Construct();
            area2[1, 0] = State.Zero;
            area2[1, 1] = State.Zero;
            area2[1, 2] = State.Zero;

            return area2;
        }

        public State[,] PresetOfZeroes3()
        {
            Construct();
            area2[2, 0] = State.Zero;
            area2[2, 1] = State.Zero;
            area2[2, 2] = State.Zero;

            return area2;
        }

        public State[,] PresetOfZeroes4()
        {
            Construct();
            area2[0, 0] = State.Zero;
            area2[1, 0] = State.Zero;
            area2[2, 0] = State.Zero;

            return area2;
        }

        public State[,] PresetOfZeroes5()
        {
            Construct();
            area2[0, 1] = State.Zero;
            area2[1, 1] = State.Zero;
            area2[2, 1] = State.Zero;

            return area2;
        }

        public State[,] PresetOfZeroes6()
        {
            Construct();
            area2[0, 2] = State.Zero;
            area2[1, 2] = State.Zero;
            area2[2, 2] = State.Zero;

            return area2;
        }

        public State[,] PresetOfZeroes7()
        {
            Construct();
            area2[0, 2] = State.Zero;
            area2[1, 1] = State.Zero;
            area2[2, 0] = State.Zero;

            return area2;
        }

        public State[,] PresetOfZeroes8()
        {
            Construct();
            area2[0, 0] = State.Zero;
            area2[1, 1] = State.Zero;
            area2[2, 2] = State.Zero;

            return area2;
        }
            #endregion
        
    }
}
