﻿using Lecture.Aids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            FileAndDirectories.UsingTheDirectoryClass(); 

            ReadingInFiles.ReadACharacterFile();

            ReadingCSVFiles.ReadFile();
            SummingUpNumbers.ReadFile();
            Console.ReadLine();
        }
    }
}
