using System.Windows.Forms;

namespace EstructuraDinamicaG6
{
    public partial class Form1 : Form
    {

        Stack<int> pila = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(tbEdad.Text);
            pila.Push(edad);
            Mostrar();
        }
        private void Mostrar()
        {
            string mensaje = "";
            foreach (int edad in pila)
            {
                mensaje += "" + edad + "/";
            }
            lblEdades.Text = mensaje;
        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                pila.Pop();
                Mostrar();

            }
            else
            {
                MessageBox.Show("La pila está vacía");
            }

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (pila.Count > 0)
            {
                MessageBox.Show("El elemento en la cima es: " + pila.Peek());
            }
            else
            {
                MessageBox.Show("La pila está vacía");
            }
        }


        //Ordenar de mayor a menor en el label lblEdades

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            OrdenarPila();
        }


        private void OrdenarPila()
        {

            
            Stack <int> pila2 = new Stack<int>();


            while(pila.Count > 0)
            {
                int temp = pila.Pop();
                
                while (pila.Count > 0 && pila2.Peek() > temp)
                {
                    pila.Push(pila2.Pop() );
                }
                pila2.Push(temp);
            }
            pila = pila2;
           
         }

        
      

    }
}
