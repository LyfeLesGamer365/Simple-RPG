﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine; 

namespace WindowsFormsApp2
{
    public partial class SuperAdventure : Form
    {
        private Player boio
            ;


        public SuperAdventure()
        {
            Location location = new Location(1, "Home", "This could be your home, hopefully.", null, null, null);
            
            boio = new Player(10, 10, 20, 0, 1);

            InitializeComponent();


            boio.CurrentHitPoints = 10;
            boio.MaximumHitPoints = 10;
            boio.Gold = 20;
            boio.Level = 1;

            lblHitPoints.Text = boio.CurrentHitPoints.ToString();
            lblGold.Text = boio.Gold.ToString();
            lblExperience.Text = boio.ExperiencePoints.ToString();
            lblLevel.Text = boio.Level.ToString();
        }


    }
}
