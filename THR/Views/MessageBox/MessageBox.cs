using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace THR.Views.Message
{
    public class MessageCuston
    {
        public DialogResult MessageBoxInfomation(string menssagem) 
        {
            return MessageBox.Show(menssagem,"THR SYSTEM",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public DialogResult MessageBoxError(string menssagem)
        {
            return MessageBox.Show(menssagem, "THR SYSTEM", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        public DialogResult MessageBoxWarning(string menssagem)
        {
            return MessageBox.Show(menssagem, "THR SYSTEM", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
