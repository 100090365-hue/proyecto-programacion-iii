using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diseño_Trabajo_final.Mantenimientos
{
  public class MantForm
  {

    private Form formActivo;
    public void AbrirFormulario(Form nuevo)
    {
      formActivo?.Close();
      formActivo = nuevo;
      nuevo.FormClosed += (s, e) => formActivo = null;
      nuevo.Show();
    }
  }
}
