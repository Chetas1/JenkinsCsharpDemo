﻿using System;

namespace JenkinsDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage()); 
        }

        public static string createMessage()
        {
            return "Hello World";
        }
    }
}
