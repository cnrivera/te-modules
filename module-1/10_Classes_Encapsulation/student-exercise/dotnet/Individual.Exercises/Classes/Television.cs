﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Television
    {
        public bool IsOn { get; private set; }
        public int CurrentChannel { get; private set; }
        public int CurrentVolume { get; private set; }

        public Television()
        {
            IsOn = false;
            CurrentChannel = 3;
            CurrentVolume = 2;
        }

        public void TurnOff()
        {
            IsOn = false;
        }

        public void TurnOn()
        {
            IsOn = true;
            CurrentVolume = 2;
            CurrentChannel = 3;
        }

        public void ChangeChannel(int newChannel)
        {
            if (IsOn == true)
                if (CurrentChannel >= 3 && CurrentChannel <= 18)
                {
                    CurrentChannel = newChannel;
                }
        }

        public void ChannelUp()
        {
            if (IsOn == true)
            {
                CurrentChannel += 1;
            
                if (CurrentChannel > 18)
                {
                    CurrentChannel = 3;
                }
            }
        }

        public void ChannelDown()
        {
            if (IsOn == true)
            {
                CurrentChannel -= 1;
            }
            if (CurrentChannel < 3)
            {
                CurrentChannel = 18;
            }
        }

        public void RaiseVolume()
        {
            if (IsOn == true && CurrentVolume < 10)
            {
                CurrentVolume += 1;
            }
        }

        public void LowerVolume()
        {
            if(IsOn == true && CurrentVolume >0)
            {
                CurrentVolume -= 1;
            }
        }
    }
}
