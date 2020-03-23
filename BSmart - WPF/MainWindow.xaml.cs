using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BSmart___WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////normativa F3
            ////Terreno
            ////Input medida de frente
            //Console.WriteLine("Ingrese medida de frente de terreno: ");
            //double Vfrente = Convert.ToDouble(Console.ReadLine());
            ////Input medida de fondo
            //Console.WriteLine("Ingrese medida de fondo de terreno: ");
            //double Vfondo = Convert.ToDouble(Console.ReadLine());

            ////Calculo superficie del terreno
            //Parametro inParametro = new Parametro();
            //int Result = inParametro.CalcularSuperficie(Vfrente, Vfondo);

            ////Escribir en el TextBox el return de vSup o Result ???


            ////Input Retiro
            //Console.WriteLine("Ingrese valor de retiro: ");
            //double Vretiro = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(Vretiro);
            ////Calculo de Superficie de retiro
            //double VsupRetiro = (Vretiro * Vfrente);
            //Console.WriteLine("La superficie del retiro es : " + VsupRetiro);
            ////Calculo de Superficie resultante despues de retiro
            //double VsupTerrenoConRetiro = (VsuperficieTerreno - VsupRetiro);
            //Console.WriteLine("La superficie del terreno con retiro es : " + VsupTerrenoConRetiro);
            ////Calculo de cual es el escenario mas desfavorable para tomar Max superficie edificable
            //double Vresult1 = VfotTerreno;
            //double Vresult2 = VfosTerreno;
            //double Vresult3 = VsupTerrenoConRetiro;
            //if (VfotTerreno < VfosTerreno && VfotTerreno < VsupTerrenoConRetiro)
            //{
            //    Console.WriteLine("La maxima superficie edificable del terreno es " + Vresult1);
            //}
            //else if (VfosTerreno < VfotTerreno && VfosTerreno < VsupTerrenoConRetiro)
            //{
            //    Console.WriteLine("La maxima superficie edificable del terreno es " + Vresult2);
            //}
            //else if ((VsupTerrenoConRetiro < VfotTerreno && VsupTerrenoConRetiro < VfosTerreno))
            //{
            //    Console.WriteLine("La maxima superficie edificable del terreno es " + Vresult3);
            //}
            ////Calculo de costo de proyecto
            //double VcostoCosntruccion = 620;//Costo estimado del metro cuadrado de construccion en dolares
            //Console.WriteLine("ingrese valor de Max. Sup. Edif, de su terreno: ");
            //double VMaxSupEdif = Convert.ToDouble(Console.ReadLine());
            //double VcostoProyecto = (VcostoCosntruccion * VMaxSupEdif);//Costo de metro de construccion por la cantidad total de m2
            //Console.WriteLine("El costo en dolares del proyecto sera " + VcostoProyecto);//resultante del costo total.




            //Parametro inParametro = new Parametro();
            //int Result = inParametro.CalcularSuperficie(20, 40);

            //Standard inStandard = new Standard();
            //var List = inStandard.Get();
        }

        private void Fondo_LostFocus(object sender, RoutedEventArgs e)
        {
            string A = "DashStyle";

            
            double Vfrente = Convert.ToDouble(int_Frente.Text);
            double Vfondo = Convert.ToDouble(int_Fondo.Text);
            //Calculo superficie del terreno
            double VsuperficieTerreno = (Vfrente * Vfondo);
            SuperficieTerreno.Text = VsuperficieTerreno.ToString();


        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            comboFot.Items.Add("0.1");
            comboFot.Items.Add("0.5");
            comboFot.Items.Add("1");

        }
        public string[] listFot { get; set; }

        private void cboFot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
