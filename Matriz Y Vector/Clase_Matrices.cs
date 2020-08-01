using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Matriz_Y_Vector
{
    class Clase_Matrices
    {

        int[,] matriz = new int[100, 100];
        int fila, columna, j, i;
        Random numeros = new Random();

        //************************************************************
        //************************************************************
        //MATRICES CUADRATICAS-DIAGONALES

        //ingreso de valores por ramdon para la matriz no cuadratica
        public void matriz_normal(TextBox pantalla1)
        {
            fila = int.Parse(pantalla1.Text);
            columna = fila;


            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    matriz[i, j] = numeros.Next(0, 20);
                }

            }

        }

     


      






        public void mostrar_matriz(DataGridView Tabla)
        {
            columna = fila;
            Tabla.RowCount = fila;
            Tabla.ColumnCount = columna;
            


            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                }

            }


        }



        public void matriz_nula(DataGridView Tabla)
        {
            columna = fila;
            Tabla.ColumnCount = columna;
            Tabla.RowCount = fila;


            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    matriz[i, j] *= 0;
                    Tabla.Rows[i].Cells[j].Value = (matriz[i, j]).ToString();
                }

            }


        }



        public void matriz_escalonada(DataGridView Tabla)
        {
            int[][] arr = new int[2][];

            arr[0] = new int[100];
            arr[1] = new int[100];
            columna = fila;

            Tabla.ColumnCount = columna;
            Tabla.RowCount = fila;


            for (i = 0; i < fila; i++)
            {


                for (j = 0; j < columna; j++)
                {

                    Tabla.Rows[i].Cells[j].Value = (matriz[i, j]).ToString();
                }

            }


        }



        public void matriz_opuesta(DataGridView Tabla)
        {
            columna = fila;
            Tabla.ColumnCount = columna;
            Tabla.RowCount = fila;

            int[,] transpuesta = new int[100, 100];

            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {

                    transpuesta[j, i] = matriz[i, j];

                    Tabla.Rows[j].Cells[i].Value = (transpuesta[j, i]).ToString();
                }

            }


        }




        public void ImprimirMayor()
        {
            //imprimir el mayor numero de la matriz   
            int mayor = matriz[0, 0];


            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] > mayor)
                    {
                        mayor = matriz[i, j];



                    }
                }
            }

            MessageBox.Show(mayor.ToString());
        }

        public void Triangulo_superior_mayor(DataGridView Tabla)
        {
            //parametro que recibe cuantas filas y columnas hace en la cuadratica
            //requiere correguir solo se necesita 1 

            columna = fila;
            Tabla.ColumnCount = columna;
            Tabla.RowCount = fila;



            int mayor = matriz[0, 0];

            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    if (i < j)
                    {
                        //crear la triangular superior 
                        Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                        //pintalas celdas del color que uno quiere
                        Tabla.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                        if (matriz[i, j] > mayor)
                        {
                            mayor = matriz[i, j];

                        }
                    }
                    else
                    {
                        //lo demas se pone con cero
                        matriz[i, j] *= 0;
                        Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                    }

                }
            }

            MessageBox.Show(mayor.ToString(),"Valor Mayor del Triangulo Superior");
        }


        public void Triangulo_inferior_mayor(DataGridView Tabla)
        {
            columna = fila;
            Tabla.ColumnCount = columna;
            Tabla.RowCount = fila;
            int mayor = matriz[0, 0];

            for (i = 0; i < fila; i++)
            {
                for (j = 0; j < columna; j++)
                {
                    {
                        if (i > j)
                        {
                            //solo aparece el triangulo superior
                            Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                            Tabla.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                            if (matriz[i, j] > mayor)
                            {
                                
                                mayor = matriz[i, j];

                            }
                        }
                        else
                        {
                            //lo demas se pone con cero
                            matriz[i, j] *= 0;
                            Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                        }
                    }

                }
            }
           

                    MessageBox.Show(mayor.ToString(), "Valor Mayor del Triangulo Inferior");

        }


        
        public void diagonal_principal_mayor(DataGridView Tabla)
        {
             fila= columna;
           
            Tabla.ColumnCount = columna;
            Tabla.RowCount = fila;

            int mayor = matriz[0, 0];

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    {
                        if (i == j)
                        {
                            //solo se imprime la diagonal
                            Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                            Tabla.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                            if (matriz[i, j] > mayor)
                            {
                               
                                mayor = matriz[i, j];
                               
                            }
                        }
                        else {
                            //lo demas se pone con cero
                            matriz[i, j] *= 0;
                            Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                        }
                    }
                }


            }
            MessageBox.Show(mayor.ToString(), "Valor Mayor de la Diagonal Principal");
        }




        public void Ascendente_Diagonal(DataGridView Tabla)
        {
            fila = columna;
            int x = fila * columna;
            int[] vector = new int[x] ;
            Tabla.ColumnCount = columna;
            Tabla.RowCount = fila;
          
            int mayor = matriz[0, 0];

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    {
                        if (i == j)
                        {
                            //solo se imprime la diagonal
                           
                            Tabla.Rows[i].Cells[j].Style.BackColor = Color.Orange;
                            for (i = 0; i < fila; i++)
                            {
                                for (j = 0; j < columna; j++)
                                {

                                    vector[x] = matriz.Length;

                                    Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();

                                }
                            }
                        }
                        else
                        {
                            //lo demas se pone con cero
                            matriz[i, j] *= 0;
                            Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();
                        }
                    }
                }


            }
            MessageBox.Show(mayor.ToString(), "Valor Mayor de la Diagonal Principal");
        

    }




    public void Eliminar_Fila_Matriz(DataGridView Tabla)
        {
           
            try
            {
                columna = fila;
                Tabla.ColumnCount = columna;
                Tabla.RowCount = fila;
                int n = 1;
                fila -= n;
            }
            catch {

                if (fila > 0)
                {
                    
                    for (int i = 0; i < fila; i++)
                    {
                        for (int j = 0; j < columna; j++)
                        {

                            Tabla.Rows[i].Cells[j].Value = matriz[i, j].ToString();

                        }
                    }


                }
                else
                {
                    MessageBox.Show(" Solo queda una fila,Imposible borrar ");
                   
                }
            }
        }



        //******************************************************
        //******************************************************
        //MATRIZ NO-CUADRATICA



        int[,] matriz_NO = new int[100, 100];
        int fila1, columna1, j1, i1;
        Random numeros1 = new Random();

        //ingreso de valores por ramdon para la matriz no cuadratica
        public void matriz_normal_no_cuadratica(TextBox pantalla1_,TextBox pantalla2_)
        {
            fila1 = int.Parse(pantalla1_.Text);
            columna1 = int.Parse(pantalla2_.Text);


            for (i1 = 0; i1 < fila1; i1++)
            {
                for (j1 = 0; j1 < columna1; j1++)
                {
                    matriz_NO[i1, j1] = numeros1.Next(0, 20);
                }

            }

        }


        public void mostrar_matriz_no_cuadratica(DataGridView Tabla)
        {
            
            Tabla.RowCount = fila1;
            Tabla.ColumnCount = columna1;



            for (i1 = 0; i1 < fila1; i1++)
            {
                for (j1 = 0; j1 < columna1; j1++)
                {
                    Tabla.Rows[i1].Cells[j1].Value = matriz_NO[i1, j1].ToString();
                }

            }


        }


        public void ImprimirMayor_No_Cuadratico()
        {
            //imprimir el mayor numero de la matriz   
            int mayor1 = matriz_NO[0, 0];


            for (int i1 = 0; i1 < matriz_NO.GetLength(0); i1++)
            {
                for (int j1 = 0; j1 < matriz_NO.GetLength(1); j1++)
                {
                    if (matriz_NO[i1, j1] > mayor1)
                    {
                        mayor1 = matriz_NO[i1, j1];



                    }
                }
            }

            MessageBox.Show(mayor1.ToString());
        }






    }
}
