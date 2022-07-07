using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Security.AccessControl;
using System.Net;

namespace RankingMusical
{
    public partial class TopMusic : Form
    {
        const string directorio = @"..\..\directory\";
        //public string directorio = Properties.Settings.Default.Directorio;
        TreeNode auxNodoPadre; TreeNode auxNodo; 
        string auxNombreNodoPadre; string auxNombreNodo;

        public TopMusic()
        {
            InitializeComponent();
            CargarNodos();
        }

        private void TopMusic_Load(object sender, EventArgs e)
        {
            btnArriba.Enabled = false;
            btnAbajo.Enabled = false;
            btnEliminar.Enabled = false;
            btnAgregar.Enabled = false;
        }
        private void TopMusic_Shown(object sender, EventArgs e)
        {
            dgvCanciones.ClearSelection();
        }

        private void CargarNodos()
        {
            tvDirectorios.Nodes.Clear();
            TreeNode aNode;
            DirectoryInfo inf = new DirectoryInfo(directorio);
            DirectoryInfo[] subDirs = inf.GetDirectories();
            foreach (DirectoryInfo directory in subDirs)
            {
                aNode = new TreeNode(directory.Name);
                tvDirectorios.Nodes.Add(aNode);

                foreach (FileInfo fi in directory.GetFiles())
                {
                    TreeNode nodo = new TreeNode();
                    nodo.Text = fi.Name;
                    int indiceNodo = tvDirectorios.Nodes.IndexOf(aNode);
                    tvDirectorios.Nodes[indiceNodo].Nodes.Add(nodo);
                    //tvDirectorios.Nodes[aNode].Nodes.Add(nodo);
                }
            }
        }
        private void VerificarDirectorio()
        {
            if (!Directory.Exists(directorio))
            {
                Directory.CreateDirectory(directorio);
            }
        }        
        private void GuardarCambios()
        {
            DirectoryInfo f = new DirectoryInfo(Path.Combine(directorio, auxNombreNodo));
            FileInfo infoArchivo = new FileInfo(f.FullName);
            int ranking = 1;
            Encoding enc = GetFileEncoding(directorio + auxNombreNodoPadre + @"\" + infoArchivo.Name);
            StreamWriter wr = new StreamWriter(directorio + auxNombreNodoPadre + @"\" + infoArchivo.Name, false, enc);
            foreach (DataGridViewRow fila in dgvCanciones.Rows)
            {
                if (!(fila.Cells[1].Value == null | fila.Cells[2].Value == null))
                {
                    string cancion = fila.Cells[1].Value.ToString().Trim();
                    string artista = fila.Cells[2].Value.ToString().Trim();
                    wr.WriteLine(cancion + "/" + artista);

                    fila.Cells[0].Value = ranking;
                    ranking += 1;
                }
            }
            wr.Close();
        }
        public void CargarArchivo(DataGridView tabla, char caracter, string ruta)
        {
            StreamReader objReader = new StreamReader(ruta, GetFileEncoding(ruta));
            string sLine = "";
            int fila = 0;
            tabla.Rows.Clear();

            do
            {
                sLine = objReader.ReadLine();
                if ((sLine != null))
                {
                    string[] arreglo = (caracter + sLine).Split(caracter);
                    tabla.Rows.Add(arreglo);
                    fila += 1;
                }
            }
            while (!(sLine == null));

            objReader.Close();
        }
        public static Encoding GetFileEncoding(string srcFile)
        {
            // *** Use Default of Encoding.Default (Ansi CodePage)
            Encoding enc = Encoding.Default;

            // *** Detect byte order mark if any - otherwise assume default
            byte[] buffer = new byte[5];
            FileStream file = new FileStream(srcFile, FileMode.Open);
            file.Read(buffer, 0, 5);
            file.Close();

            if (buffer[0] == 0xef && buffer[1] == 0xbb && buffer[2] == 0xbf)
                enc = Encoding.UTF8;
            else if (buffer[0] == 0xfe && buffer[1] == 0xff)
                enc = Encoding.Unicode;
            else if (buffer[0] == 0 && buffer[1] == 0 && buffer[2] == 0xfe && buffer[3] == 0xff)
                enc = Encoding.UTF32;
            else if (buffer[0] == 0x2b && buffer[1] == 0x2f && buffer[2] == 0x76)
                enc = Encoding.UTF7;

            return enc;
        }
        //Eventos de TreeView
        private void tvDirectorios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvDirectorios.SelectedNode.GetNodeCount(false) == 0)
            {
                auxNodo = e.Node;
                auxNombreNodo = auxNodo.Text;
                DirectoryInfo file = new DirectoryInfo(Path.Combine(directorio, auxNombreNodo));
                String atributos = file.Attributes.ToString();

                if (!atributos.Contains(FileAttributes.Directory.ToString()))
                {
                    auxNodoPadre = e.Node.Parent;
                    auxNombreNodoPadre = auxNodoPadre.Text;
                    FileInfo infoArchivo = new FileInfo(file.FullName);
                    CargarArchivo(dgvCanciones, '/', directorio + auxNombreNodoPadre + @"\" + infoArchivo.Name);
                }

                if (txtBuscador.Text != "") { BuscarCancion(false); }
            }

            dgvCanciones.ClearSelection();
            btnArriba.Enabled = false;
            btnAbajo.Enabled = false;
            btnEliminar.Enabled = false;
        }
        private void tvDirectorios_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeViewHitTestInfo info = tvDirectorios.HitTest(e.X, e.Y);
                auxNodo = info.Node;
                auxNombreNodo = auxNodo.Text;

                if (auxNodo.Level == 0)
                {
                    cmsCarpeta.Show(tvDirectorios, new Point(e.X, e.Y));
                }

                if (auxNodo.Level == 1)
                {
                    auxNodoPadre = info.Node.Parent;
                    auxNombreNodoPadre = auxNodoPadre.Text;
                    cmsArchivo.Show(tvDirectorios, new Point(e.X, e.Y));
                }
            }
        }
        private void tvDirectorios_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Node.Text == e.Label | String.IsNullOrEmpty(e.Label)) { return; }

            if (e.Node.Level == 0)
	        {
                Directory.Move(directorio + e.Node.Text, directorio + e.Label);
	        }

            if (e.Node.Level == 1)
            {
                File.Move(directorio + e.Node.Parent.Text + @"\" + e.Node.Text, directorio + e.Node.Parent.Text + @"\" + e.Label);   
            }
        }
        private void tvDirectorios_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode nodo = e.Node;
            btnAgregar.Enabled = false;
            btnDescargarTXT.Enabled = false;

            if (nodo.Level == 1)
            {
                btnAgregar.Enabled = true;
                btnDescargarTXT.Enabled = true;
            }
        }
        //Eventos de DataGridView
        private void dgvCanciones_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            GuardarCambios();
        }
        private void dgvCanciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            
            if (e.ColumnIndex == 0)
            {
                int fila = e.RowIndex;
                dgvCanciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvCanciones.Rows[fila].Selected = true;
                btnArriba.Enabled = true;
                btnAbajo.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                dgvCanciones.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dgvCanciones.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                btnArriba.Enabled = false;
                btnAbajo.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }
        private void dgvCanciones_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int ranking = 1;
            foreach (DataGridViewRow fila in dgvCanciones.Rows)
            {
                if (!(fila.Cells[1].Value == null | fila.Cells[2].Value == null))
                {
                    fila.Cells[0].Value = ranking;
                    ranking += 1;
                }
            }

            //if (auxNodo.Level == 1)
            //{
            //    int altoDataGridView = 46;
            //    foreach (DataGridViewRow fila in dgvCanciones.Rows)
            //    {
            //        altoDataGridView += (int)fila.Height;
            //    }
            //    dgvCanciones.Height = altoDataGridView;
            //    //if (dgvCanciones.Height > 463) { dgvCanciones.Height = 463; }
            //}
        }
        //Crear carpeta
        private void txtCarpeta_TextChanged(object sender, EventArgs e)
        {
            if (txtCarpeta.Text.Trim() != String.Empty)
            {
                btnCrearCarpeta.Enabled = true;
            }
            else
            {
                btnCrearCarpeta.Enabled = false;
            }
        }
        private void btnCrearCarpeta_Click(object sender, EventArgs e)
        {
            try 
	        {
                string newFolder = Path.Combine(directorio, txtCarpeta.Text);
                if (Directory.Exists(newFolder))
                {
                    MessageBox.Show("El nombre de genero ya existe.");
                    return;
                }

                Directory.CreateDirectory(newFolder);
                CargarNodos();
                txtCarpeta.Text = String.Empty;
	        }
	        catch (Exception ex)
	        {
                MessageBox.Show(ex.ToString());
	        }
        }
        //Eliminar carpeta
        private void tsmiEliminarCarpeta_Click(object sender, EventArgs e)
        {
            Directory.Delete(directorio + auxNombreNodo);
            CargarNodos();
        }
        //Agregar archivo
        private void tsmiAgregarArchivo_Click(object sender, EventArgs e)
        {
            panArchivo.Visible = true;
            panArchivo.Location = tvDirectorios.Location;
            txtArchivo.Focus();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            panArchivo.Visible = false;
        }
        private void txtArchivo_TextChanged(object sender, EventArgs e)
        {
            if (txtArchivo.Text.Trim() != String.Empty)
            {
                btnAceptar.Enabled = true;
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string newCarpeta = Path.Combine(directorio, auxNombreNodo);
                string newFile = Path.Combine(newCarpeta, txtArchivo.Text);

                if (File.Exists(newFile + ".txt"))
                {
                    MessageBox.Show("El nombre de subgenero ya existe.");
                    return;
                }

                File.Create(newFile + ".txt");
                StreamWriter sw = new StreamWriter(newFile + ".txt", true);
                sw.Write(" / ");
                sw.Close();
                CargarNodos();
                txtArchivo.Text = String.Empty;
                panArchivo.Visible = false;
                btnAceptar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //Eliminar archivo
        private void tsmiEliminarArchivo_Click(object sender, EventArgs e)
        {
            File.Delete(directorio + auxNombreNodoPadre + @"\" + auxNombreNodo);
            CargarNodos();
        }
        //Mover archivo
        private void tsmiMover_Click(object sender, EventArgs e)
        {
            panDestinoArchivo.Visible = true;
            panDestinoArchivo.Location = tvDirectorios.Location;
            cboCarpetas.Items.Clear();
            for (int i = 0; i < tvDirectorios.Nodes.Count; i++)
            {
                cboCarpetas.Items.Add(tvDirectorios.Nodes[i].Text);
            }
            cboCarpetas.Focus();
        }
        private void cboCarpetas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            File.Move(directorio + auxNombreNodoPadre + @"\" + auxNombreNodo, directorio + cboCarpetas.SelectedItem + @"\" + auxNombreNodo);
            panDestinoArchivo.Visible = false;
            tvDirectorios.Nodes.Clear();
            CargarNodos();
        }
        private void btnCancelarArchivo_Click(object sender, EventArgs e)
        {

        }
        //Cambiar ranking
        private void btnArriba_Click(object sender, EventArgs e)
        {
            int auxIndice = dgvCanciones.SelectedRows[0].Index;
            if (auxIndice == 0) { return; }
            int auxFila = auxIndice - 1;

            string filaCancionSuperior = dgvCanciones.Rows[auxIndice - 1].Cells[1].Value.ToString();
            dgvCanciones.Rows[auxIndice - 1].Cells[1].Value = dgvCanciones.Rows[auxIndice].Cells[1].Value;
            dgvCanciones.Rows[auxIndice].Cells[1].Value = filaCancionSuperior;

            string filaArtistaSuperior = dgvCanciones.Rows[auxIndice - 1].Cells[2].Value.ToString();
            dgvCanciones.Rows[auxIndice - 1].Cells[2].Value = dgvCanciones.Rows[auxIndice].Cells[2].Value;
            dgvCanciones.Rows[auxIndice].Cells[2].Value = filaArtistaSuperior;

            if (auxFila > 0) { btnArriba.Enabled = true; } else { btnArriba.Enabled = false; }
            if (auxFila < dgvCanciones.Rows.Count - 1) { btnAbajo.Enabled = true; } else { btnAbajo.Enabled = false; }

            GuardarCambios();
            BuscarCancion(false);
            dgvCanciones.Rows[auxIndice - 1].Selected = true;
        }
        private void btnAbajo_Click(object sender, EventArgs e)
        {
            if (dgvCanciones.SelectedRows[0].Index <= 0) { return; }
            int auxIndice = dgvCanciones.SelectedRows[0].Index;
            if (auxIndice == dgvCanciones.RowCount - 1) { return; }
            int auxFila = auxIndice + 1;

            string filaCancionInferior = dgvCanciones.Rows[auxIndice + 1].Cells[1].Value.ToString();
            dgvCanciones.Rows[auxIndice + 1].Cells[1].Value = dgvCanciones.Rows[auxIndice].Cells[1].Value;
            dgvCanciones.Rows[auxIndice].Cells[1].Value = filaCancionInferior;

            string filaArtistaInferior = dgvCanciones.Rows[auxIndice + 1].Cells[2].Value.ToString();
            dgvCanciones.Rows[auxIndice + 1].Cells[2].Value = dgvCanciones.Rows[auxIndice].Cells[2].Value;
            dgvCanciones.Rows[auxIndice].Cells[2].Value = filaArtistaInferior;

            if (auxFila > 0) { btnArriba.Enabled = true; } else { btnArriba.Enabled = false; }
            if (auxFila < dgvCanciones.Rows.Count - 1) { btnAbajo.Enabled = true; } else { btnAbajo.Enabled = false; }

            GuardarCambios();
            BuscarCancion(false);
            dgvCanciones.Rows[auxIndice + 1].Selected = true;
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            dgvCanciones.Rows.Remove(dgvCanciones.CurrentRow);
            btnEliminar.Enabled = false;
            GuardarCambios();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvCanciones.Rows.Count - 1; i++)
            {
                dgvCanciones.Rows[dgvCanciones.Rows.Count - 1].Cells[1].Selected = true;
            }
        }
    
        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {
            BuscarCancion(true);
        }
        private void BuscarCancion(bool pSeleccionar)
        {
            int cont = txtBuscador.Text.Length;
            for (int i = 0; i < dgvCanciones.Rows.Count - 1; i++)
            {
                if (dgvCanciones.Rows[i].Cells[1].Value.ToString().Length >= cont)
                {
                    if (dgvCanciones.Rows[i].Cells[1].Value.ToString().ToUpper().Substring(0, cont) == txtBuscador.Text.ToUpper()
                        & txtBuscador.Text != "")
                    {
                        dgvCanciones.Rows[i].Cells[1].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgvCanciones.Rows[i].Cells[1].Style.BackColor = Color.White;
                    }
                }
                else
                {
                    dgvCanciones.Rows[i].Cells[1].Style.BackColor = Color.White;
                }
            }

            //if (pSeleccionar)
            //{
            //    bool auxBandera = false;
            //    for (int i = 0; i < dgvCanciones.Rows.Count - 1; i++)
            //    {
            //        if ((dgvCanciones.Rows[i].Cells[1].Style.BackColor == Color.Yellow |
            //            dgvCanciones.Rows[i].Cells[2].Style.BackColor == Color.Yellow) &
            //            auxBandera == false)
            //        {
            //            dgvCanciones.Rows[i].Cells[0].Selected = true;
            //            auxBandera = true;
            //        }
            //    }
            //}
        }
        
        private void txtBuscarArtista_TextChanged(object sender, EventArgs e)
        {
            BuscarArtista(true);
        }
        private void BuscarArtista(bool pSeleccionar)
        {
            int cont = txtBuscarArtista.Text.Length;
            for (int i = 0; i < dgvCanciones.Rows.Count - 1; i++)
            {
                if (dgvCanciones.Rows[i].Cells[2].Value.ToString().Length >= cont)
                {
                    if (dgvCanciones.Rows[i].Cells[2].Value.ToString().ToUpper().Substring(0, cont) == txtBuscarArtista.Text.ToUpper()
                        & txtBuscarArtista.Text != "")
                    {
                        dgvCanciones.Rows[i].Cells[2].Style.BackColor = Color.Yellow;
                    }
                    else
                    {
                        dgvCanciones.Rows[i].Cells[2].Style.BackColor = Color.White;
                    }
                }
            }

            //if (pSeleccionar)
            //{
            //    bool auxBandera = false;
            //    for (int i = 0; i < dgvCanciones.Rows.Count - 1; i++)
            //    {
            //        if ((dgvCanciones.Rows[i].Cells[2].Style.BackColor == Color.Yellow) &
            //            auxBandera == false)
            //        {
            //            dgvCanciones.Rows[i].Cells[0].Selected = true;
            //            auxBandera = true;
            //        }
            //    }
            //}
        }

        private void btnDescargarTXT_Click(object sender, EventArgs e)
        {
            SaveFileDialog guardarArchivo = new SaveFileDialog();
            guardarArchivo.DefaultExt = "txt";
            guardarArchivo.Filter = "Text Files | *.txt";
            guardarArchivo.Title = "Descargar " + auxNodo.Text;
            guardarArchivo.FileName = auxNodo.Text;
            DialogResult result = guardarArchivo.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {
                    File.AppendAllText(guardarArchivo.FileName,
                        File.ReadAllText(directorio + @"\" + auxNodo.Parent.Text + @"\" + auxNodo.Text, GetFileEncoding(directorio + @"\" + auxNodo.Parent.Text + @"\" + auxNodo.Text)));
                    MessageBox.Show("Archivo descargado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }
    }
}
