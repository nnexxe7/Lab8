using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Przybieżeli do Betlejem pasterze, Grając skocznie Dzieciąteczku na lirze. Chwała na wysokości, chwała na wysokości,A pokój na ziemi." +
                "\n\nOddawali swe ukłony w pokorze Tobie z serca ochotnego, o Boże! Chwała na wysokości..." +
                "\n\nAnioł Pański sam ogłosił te dziwy,Których oni nie słyszeli, jak żywi.Chwała na wysokości..." +
                "\n\nDziwili się napowietrznej muzycei myśleli, co to będzie za Dziecię? Chwała na wysokości..." +
                "\n\nOto mu się wół i osioł kłaniają,Trzej królowie podarunki oddają. Chwała na wysokości..." +
                "\n\nI anieli gromadą pilnująPanna czysta wraz z Józefem pilnują Chwała na wysokości..." +
                "\n\nPoznali Go Mesjaszem być prawymNarodzonym dzisiaj Panem łaskawym Chwała na wysokości..." +
                "\n\nMy go także Bogiem, Zbawcą już znamyI z całego serca wszystko kochamy Chwała na wysokości...";
            SoundPlayer player = new SoundPlayer(Properties.Resources.Koleda1);
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Cicha noc, święta noc,Pokój niesie ludziom wszem,A u żłóbka Matka ŚwiętaCzuwa sama uśmiechniętaNad dzieciątka snem,Nad dzieciątka snem." +
                "\n\nCicha noc, święta noc,Pastuszkowie od swych trzód Za anielskim głosem pieniGdzie się spełnił cud,Gdzie się spełnił cud." +
                "\n\nCicha noc, święta noc,Narodzony Boży SynPan Wielkiego majestatuNiesie dziś całemu światu Odkupienie win,Odkupienie win." +
                "\n\nCicha noc, święta noc,Jakiż w tobie dzisiaj czas W Betlejem dziecina świętaWznosi w górę swe rączęta,Błogosławi nam,Błogosławi lud.";
            SoundPlayer player = new SoundPlayer(Properties.Resources.Koleda2);
            player.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Pójdźmy wszyscy do stajenki Do Jezusa i Panienki" +
                "\n\nPowitajmy MaleńkiegoI Maryję, matkę Jego Powitajmy MaleńkiegoI Maryję, matkę Jego" +
                "\n\nWitaj, Jezu ukochany Od Patriarchów czekany" +
                "\n\nOd Proroków ogłoszony Od narodów upragniony Od Proroków ogłoszony Od narodów upragniony" +
                "\n\nWitaj, Dziecineczko w żłobie Wyznajemy Boga w Tobie" +
                "\n\nCoś się narodził tej nocy Boś nas wyrwał z czarta mocy Coś się narodził tej nocyBoś nas wyrwał z czarta mocy";
            SoundPlayer player = new SoundPlayer(Properties.Resources.Koleda3);
            player.Play();
        }
    }
}
