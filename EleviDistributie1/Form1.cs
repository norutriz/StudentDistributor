using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace EleviDistributie1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxEleviA.Text = "0";
            textBoxEleviB.Text = "0";
            textBoxEleviC.Text = "0";
            textBoxEleviD.Text = "0";
        }

        //butonul de import
        //user-ul alege fisierul excel din care se iau elevii
        //dupa aceasta se afiseaza lista de elevi
        List<string> listaElevi = new List<string>();
        List<string> listaEleviNeDistribuiti = new List<string>();
        List<float> listaMediiElevi = new List<float>();
        private void ButtonImport_Click(object sender, EventArgs e)
        {
            listBoxElevi.Items.Clear();
            string file = null;
            openFileDialog1.Filter = "Microsoft Excel 97-2003 (*.xls)|*.xls|Microsoft Excel (*.xlsx)|*.xlsx";
            DialogResult result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                listBoxElevi.Items.Clear(); //daca se importa de mai multe ori se tot adauga la lista, asa rezolvam problema asta
                file = openFileDialog1.FileName;

                Excel.Application excelApp;
                Excel.Workbook excelWorkbook;
                Excel.Worksheet excelWorkSheet;
                Excel.Range range;

                string numeElev;
                float medieElev;
                int nrRanduri;
                int randuriTotal = 0;
                int coloaneTotal = 0;

                excelApp = new Excel.Application(); //deschidem excel-ul
                excelWorkbook = excelApp.Workbooks.Open(@file, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
                excelWorkSheet = (Excel.Worksheet)excelWorkbook.Worksheets.get_Item(1);

                range = excelWorkSheet.UsedRange;
                randuriTotal = range.Rows.Count;
                coloaneTotal = range.Columns.Count;

                if (coloaneTotal > 2)
                {
                    MessageBox.Show("Nu ati formatat bine fisierul de intrare!");
                    listBoxElevi.Items.Clear();
                    return;
                }

                for (nrRanduri = 1; nrRanduri <= randuriTotal; nrRanduri++) //punem in lista cu elevi
                {
                    numeElev = (string)(range.Cells[nrRanduri, 1] as Excel.Range).Value2;
                    if (coloaneTotal == 2)
                    {
                        try
                        {
                            medieElev = (float)(range.Cells[nrRanduri, 2] as Range).Value2;
                            listaMediiElevi.Add(medieElev);
                            listBoxElevi.Items.Add(numeElev);
                            listaElevi.Add(numeElev);
                            listaEleviNeDistribuiti.Add(numeElev);
                        }
                        catch
                        {
                            MessageBox.Show("Nu ati introdus bine mediile!");
                            listBoxElevi.Items.Clear(); 
                            nrRanduri = randuriTotal + 1;
                            ButtonImport_Click(sender, e);
                        }
                    }                    
                }

                excelWorkbook.Close(true, null, null);
                excelApp.Quit();

                Marshal.ReleaseComObject(excelWorkSheet);
                Marshal.ReleaseComObject(excelWorkbook);
                Marshal.ReleaseComObject(excelApp);
            }
            else
            {
                MessageBox.Show("Selectati alt fisier");
                listBoxElevi.Items.Clear();
                return;
            }                
        }

        //se distribuie random pe clase elevii din listBoxElevi
        private void ButtonDistributie_Click(object sender, EventArgs e)
        {
            if (!checkBoxMedie.Checked)
            {
                listBoxEleviA.Items.Clear(); //daca se distribuie de mai multe ori se tot adauga la lista, asa oprim asta
                listBoxEleviB.Items.Clear();
                listBoxEleviC.Items.Clear();
                listBoxEleviD.Items.Clear();

                int nrMaxEleviA = Convert.ToInt32(textBoxEleviA.Text);
                int nrMaxEleviB = Convert.ToInt32(textBoxEleviB.Text);
                int nrMaxEleviC = Convert.ToInt32(textBoxEleviC.Text);
                int nrMaxEleviD = Convert.ToInt32(textBoxEleviD.Text);
                int nrMaxEleviClase = nrMaxEleviA + nrMaxEleviB + nrMaxEleviC;
                if (nrMaxEleviD > 0)                // nu avem tot timpul 4 clase
                    nrMaxEleviClase += nrMaxEleviD;

                while (nrMaxEleviClase > listaElevi.Count())
                {
                    MessageBox.Show("Numarul de elevi ceruti in clase este mai mare decat numarul de elevi disponibili");
                    textBoxEleviA.Text = "0";
                    textBoxEleviB.Text = "0";
                    textBoxEleviC.Text = "0";
                    textBoxEleviD.Text = "0";
                    nrMaxEleviClase = 0;
                    return;
                }

                if (nrMaxEleviClase > listaElevi.Count())
                {
                    MessageBox.Show("Ati incercat sa repartizati prea multi elevi");
                    return;
                }

                if (nrMaxEleviClase <= 0)
                {
                    MessageBox.Show("Nu ati dat numarul de elevi per clasa");
                    return;
                }

                if (textBoxNumeA.Text == "" || textBoxNumeB.Text == "" || textBoxNumeC.Text == "")
                {
                    MessageBox.Show("Nu ati dat numele claselor");
                    return;
                }
                if (Convert.ToInt32(textBoxEleviD.Text) > 0 && textBoxNumeD.Text == "")
                {
                    MessageBox.Show("Nu ati dat numele claselor");
                    return;
                }

                Random random = new Random();
                int intRandom = random.Next(0, listaElevi.Count());
                List<int> randomList = new List<int>();

                int eleviA = 0;
                int eleviB = 0;
                int eleviC = 0;
                int eleviD = 0;
                while (eleviA < nrMaxEleviA)   //avem grija sa nu fie mai multi decat trebuie pe clasa
                {
                    while (randomList.Contains(intRandom))              //verificam sa nu punem acelasi elev in mai multe clase
                        intRandom = random.Next(0, nrMaxEleviClase);

                    randomList.Add(intRandom);
                    listBoxEleviA.Items.Add(listaElevi[intRandom]);
                    listaEleviNeDistribuiti.Remove(listaElevi[intRandom]);
                    eleviA++;
                }

                while (eleviB < nrMaxEleviB)
                {
                    while (randomList.Contains(intRandom))
                        intRandom = random.Next(0, nrMaxEleviClase);

                    randomList.Add(intRandom);
                    listBoxEleviB.Items.Add(listaElevi[intRandom]);
                    listaEleviNeDistribuiti.Remove(listaElevi[intRandom]);
                    eleviB++;
                }

                while (eleviC < nrMaxEleviC)
                {
                    while (randomList.Contains(intRandom))
                        intRandom = random.Next(0, nrMaxEleviClase);

                    randomList.Add(intRandom);
                    listBoxEleviC.Items.Add(listaElevi[intRandom]);
                    listaEleviNeDistribuiti.Remove(listaElevi[intRandom]);
                    eleviC++;
                }

                if (nrMaxEleviD > 0)
                    while (eleviD < nrMaxEleviD)
                    {
                        while (randomList.Contains(intRandom))
                            intRandom = random.Next(0, nrMaxEleviClase);

                        randomList.Add(intRandom);
                        listBoxEleviD.Items.Add(listaElevi[intRandom]);
                        listaEleviNeDistribuiti.Remove(listaElevi[intRandom]);
                        eleviD++;
                    }

                listBoxEleviA.Show();
                listBoxEleviB.Show();
                listBoxEleviC.Show();
                if (nrMaxEleviD > 0)
                    listBoxEleviD.Show();
            }
            else
            {
                if (listaMediiElevi.Count.Equals(0))
                {
                    MessageBox.Show("Nu ati dat mediile in fisierul de intrare");
                    ButtonImport_Click(sender, e);
                    return;
                }

                listBoxEleviA.Items.Clear(); //daca se distribuie de mai multe ori se tot adauga la lista, asa oprim asta
                listBoxEleviB.Items.Clear();
                listBoxEleviC.Items.Clear();
                listBoxEleviD.Items.Clear();

                int nrMaxEleviA = Convert.ToInt32(textBoxEleviA.Text);
                int nrMaxEleviB = Convert.ToInt32(textBoxEleviB.Text);
                int nrMaxEleviC = Convert.ToInt32(textBoxEleviC.Text);
                int nrMaxEleviD = Convert.ToInt32(textBoxEleviD.Text);
                int nrMaxEleviClase = nrMaxEleviA + nrMaxEleviB + nrMaxEleviC;
                if (nrMaxEleviD > 0)                // nu avem tot timpul 4 clase
                    nrMaxEleviClase += nrMaxEleviD;

                while (nrMaxEleviClase > listaElevi.Count())
                {
                    MessageBox.Show("Numarul de elevi ceruti in clase este mai mare decat numarul de elevi disponibili");
                    textBoxEleviA.Text = "0";
                    textBoxEleviB.Text = "0";
                    textBoxEleviC.Text = "0";
                    textBoxEleviD.Text = "0";
                    nrMaxEleviClase = 0;
                    return;
                }

                if (nrMaxEleviClase > listaElevi.Count())
                {
                    MessageBox.Show("Ati incercat sa repartizati prea multi elevi");
                    return;
                }

                if (nrMaxEleviClase <= 0)
                {
                    MessageBox.Show("Nu ati dat numarul de elevi per clasa");
                    return;
                }
                
                if (textBoxNumeA.Text == "" || textBoxNumeB.Text == "" || textBoxNumeC.Text == "")
                {
                    MessageBox.Show("Nu ati dat numele claselor");
                    return;
                }
                if (Convert.ToInt32(textBoxEleviD.Text) > 0 && textBoxNumeD.Text == "")
                {
                    MessageBox.Show("Nu ati dat numele claselor");
                    return;
                }

                float aux;
                string aux_s;
                bool ok;
                
                do
                {
                    ok = false;
                    for (int i = 0; i < listaElevi.Count - 1; i++)
                    {
                        if (listaMediiElevi[i] < listaMediiElevi[i + 1])
                        {
                            aux = listaMediiElevi[i];
                            listaMediiElevi[i] = listaMediiElevi[i + 1];
                            listaMediiElevi[i + 1] = aux;

                            aux_s = listaElevi[i];
                            listaElevi[i] = listaElevi[i + 1];
                            listaElevi[i + 1] = aux_s;

                            ok = true;
                        }
                    }
                } while (ok);

                int eleviA = 0;
                int eleviB = 0;
                int eleviC = 0;
                int eleviD = 0;
                int contor = 0;
                while (eleviA < nrMaxEleviA)   //avem grija sa nu fie mai multi decat trebuie pe clasa
                {
                    listBoxEleviA.Items.Add(listaElevi[contor]);
                    listaEleviNeDistribuiti.Remove(listaElevi[contor]);
                    eleviA++;
                    contor++;
                }

                while (eleviB < nrMaxEleviB)
                {
                    listBoxEleviB.Items.Add(listaElevi[contor]);
                    listaEleviNeDistribuiti.Remove(listaElevi[contor]);
                    eleviB++;
                    contor++;
                }

                while (eleviC < nrMaxEleviC)
                {
                    listBoxEleviC.Items.Add(listaElevi[contor]);
                    listaEleviNeDistribuiti.Remove(listaElevi[contor]);
                    eleviC++;
                    contor++;
                }

                if (nrMaxEleviD > 0)
                    while (eleviD < nrMaxEleviD)
                    {
                        listBoxEleviD.Items.Add(listaElevi[contor]);
                        listaEleviNeDistribuiti.Remove(listaElevi[contor]);
                        eleviD++;
                        contor++;
                    }

                listBoxEleviA.Show();
                listBoxEleviB.Show();
                listBoxEleviC.Show();
                if (nrMaxEleviD > 0)
                    listBoxEleviD.Show();
            }
        }

        //export-ul datelor intr-un alt excel
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();

            if (ExcelApp == null)
            {
                MessageBox.Show("Excel nu este bine instalat!");
                return;
            }

            Excel.Workbook ExcelWorkbook;
            Excel.Worksheet ExcelWorksheet;
            object misValue = System.Reflection.Missing.Value;

            ExcelWorkbook = ExcelApp.Workbooks.Add(misValue);
            ExcelWorksheet = (Excel.Worksheet)ExcelWorkbook.Worksheets.get_Item(1);

            List<string> listaEleviA = listBoxEleviA.Items.OfType<string>().ToList();
            List<string> listaEleviB = listBoxEleviB.Items.OfType<string>().ToList();
            List<string> listaEleviC = listBoxEleviC.Items.OfType<string>().ToList();
            List<string> listaEleviD = listBoxEleviD.Items.OfType<string>().ToList();

            if (listaEleviA.Count() == 0 || listaEleviB.Count() == 0 || listaEleviC.Count() == 0)
            {
                MessageBox.Show("Nu ati importat sau distribuit elevi!");
                return;
            }

            if (checkBox1.Checked.Equals(false))
                if(sigla != null)
                    ExcelWorksheet.Shapes.AddPicture(sigla, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 35, 50);
                else
                    try
                    {
                        sigla = System.IO.File.ReadAllText("info.txt");
                        ExcelWorksheet.Shapes.AddPicture(sigla, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 0, 0, 35, 50);
                    }
                    catch
                    {
                        MessageBox.Show("Nu ati selectat o sigla!");
                    }

            int contor = 6;
            ExcelWorksheet.Cells[2, 5] = "Colegiul Național de Informatică 'Traian Lalescu' Hunedoara";
            ExcelWorksheet.Cells[3, 7] = "Distribuție elevi pe clase";
            ExcelWorksheet.Cells[6, 1] = "Nr. crt";
            ExcelWorksheet.Cells[6, 2] = "Nume și prenume";
            ExcelWorksheet.Cells[6, 3] = "Clasa";

            for (int i = 0; i < listaEleviA.Count(); i++)
            {
                contor++;
                ExcelWorksheet.Cells[contor, 1] = contor - 6;
                ExcelWorksheet.Cells[contor, 2] = listaEleviA[i];
                ExcelWorksheet.Cells[contor, 3] = textBoxNumeA.Text;
            }
            for (int i = 0; i < listaEleviB.Count(); i++)
            {
                contor++;
                ExcelWorksheet.Cells[contor, 1] = contor - 6;
                ExcelWorksheet.Cells[contor, 2] = listaEleviB[i];
                ExcelWorksheet.Cells[contor, 3] = textBoxNumeB.Text; ;
            }
            for (int i = 0; i < listaEleviC.Count(); i++)
            {
                contor++;
                ExcelWorksheet.Cells[contor, 1] = contor - 6;
                ExcelWorksheet.Cells[contor, 2] = listaEleviC[i];
                ExcelWorksheet.Cells[contor, 3] = textBoxNumeC.Text;
            }
            if (listaEleviD.Count() > 0)
                for (int i = 0; i < listaEleviD.Count(); i++)
                {
                    contor++;
                    ExcelWorksheet.Cells[contor, 1] = contor - 6;
                    ExcelWorksheet.Cells[contor, 2] = listaEleviD[i];
                    ExcelWorksheet.Cells[contor, 3] = textBoxNumeD.Text;
                }

            for (int i = 0;i < listaEleviNeDistribuiti.Count();i ++)
            {
                contor++;
                ExcelWorksheet.Cells[contor, 1] = contor - 6;
                ExcelWorksheet.Cells[contor, 2] = listaEleviNeDistribuiti[i];
                ExcelWorksheet.Cells[contor, 3] = "Nerepartizat";
            }

            string numeDefault = "Rezultat";

            SaveFileDialog dialogSalvare = new SaveFileDialog(); //dialogul din care se alege unde se salveaza
            dialogSalvare.FileName = numeDefault;
            dialogSalvare.AddExtension = true; //daca utilizatorul nu da o extensie o punem automat
            dialogSalvare.DefaultExt = "xls";
            dialogSalvare.Filter = "Microsoft Excel 97-2003(*.xls)|*.xls|All files (*.*)|*.*";

            if (dialogSalvare.ShowDialog() == DialogResult.OK)
            { 
                string savePath = Path.GetDirectoryName(dialogSalvare.FileName);

                ExcelWorkbook.SaveAs(dialogSalvare.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                ExcelWorkbook.Close(true, misValue, misValue);
                ExcelApp.Quit();

                Marshal.ReleaseComObject(ExcelWorksheet);
                Marshal.ReleaseComObject(ExcelWorkbook);
                Marshal.ReleaseComObject(ExcelApp);

                MessageBox.Show("Fisier creat");
            }
            else
                MessageBox.Show("Nu s-a putut crea fisierul");
        }

        //cand se face click pe o casuta cu nr de elevi se selecteaza tot textul
        //util pentru ca valoarea initiala este 0
        private void TextBoxEleviA_Click(object sender, EventArgs e)
        {
            textBoxEleviA.SelectAll();
        }

        private void TextBoxEleviB_Click(object sender, EventArgs e)
        {
            textBoxEleviB.SelectAll();
        }

        private void TextBoxEleviC_Click(object sender, EventArgs e)
        {
            textBoxEleviC.SelectAll();
        }

        private void TextBoxEleviD_Click(object sender, EventArgs e)
        {
            textBoxEleviD.SelectAll();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        // se poate adaunga sigla scolii in fisierul exportat, daca se doreste acest lucru
        string sigla = null;
        private void Button2_Click(object sender, EventArgs e)
        {
            
            openFileDialog2.Filter = "Bitmap image (*.bmp)|*.bmp|JPEG image (*.jpg)|*.jpg|Portable network graphics (*.png)|*.png";
            DialogResult result = openFileDialog2.ShowDialog();

            if (result == DialogResult.OK)
            {
                sigla = openFileDialog2.FileName;
            }

            System.IO.File.WriteAllText("info.txt", sigla);
        }

        
    }

}
