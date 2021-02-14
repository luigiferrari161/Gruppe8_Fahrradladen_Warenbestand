﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace UI_Warenbestand
{
    /// <summary>
    /// Interaktionslogik für Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        
        private void home_Click(object sender, RoutedEventArgs e)
        {
            Window home = new MainWindow();
            home.Show();
            this.Close();
        }

        
        private void warenbestand_Click(object sender, RoutedEventArgs e)
        {
            Window warenbestand = new UI_Warenbestand.Window1();
            warenbestand.Show();
            this.Close();
        }


        private void bestellungen_Click(object sender, RoutedEventArgs e)
        {
            Window bestellungen = new UI_Warenbestand.Bestellungen();
            bestellungen.Show();
            this.Close();
        }
     
        // Exit Button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // Die Click Events fuer die Warenbestand Buttons
        // Wuerde gerne Rueckmeldung zur Implementierung haben
        // Sie zu clicken fuert zumindest zu keinem Crash daher vorerst kein Auskommentieren noetig

        private void btn_WarenHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            // Der Button Soll es NUR erlauben das Hinzuzufuegen da im Default die "CanUser" statements zu "false" gesetzt sind damit man nicht ausversehen aenderungen vornimmt
            dtg_Warenbestand.CanUserAddRows = true;
            dtg_Warenbestand.CanUserDeleteRows = false;

            // Offline row hinzufuegen zum DataGrid fuer Testzwecke (und da die Datenbank nicht so recht klappt)
            // Da es nur offline ist werden diese beim wechseln der Ansichten nicht gespeichert!!!
            //dtg_Warenbestand.Items.Add(new { ID = "Test1", Name = "Test2", Preis = "Test3" });
        }

        private void btn_WarenLoeschen_Click(object sender, RoutedEventArgs e)
        {
            // Der Button Soll es NUR erlauben das Loeschen da im Default die "CanUser" statements zu "false" gesetzt sind damit man nicht ausversehen aenderungen vornimmt
            dtg_Warenbestand.CanUserDeleteRows = true;
            dtg_Warenbestand.CanUserAddRows = false;

        }

        private void btn_WarenAendern_Click(object sender, RoutedEventArgs e)
        {
            // Hier muss noch rumgewerkelt werden !!
            //dtg_Warenbestand.BeginEdit   ?
        }
    }

}

