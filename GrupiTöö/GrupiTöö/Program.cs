﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupiTöö
{
    class Program
    {
        static void Main(string[] args)
        {

            Esimene esimeneül = new Esimene();
            esimeneül.Arvud();

            //Suht jama on jah, viskab mingid konfliktid sisse siia...
            //kttekst.txt fail panna debug folderisse
            Teine teineül = new Teine();
            teineül.Luger();
            
            //Kuradi mergeimine on täielik jama
            Kolmas kolmasül = new Kolmas();
            kolmasül.ülesanded();

            Console.ReadKey();

        }
             
    }
}
