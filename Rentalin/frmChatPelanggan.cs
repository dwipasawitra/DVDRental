using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Rentalin
{
    public partial class frmChatPelanggan : Form
    {
        DataTable chat;

        public frmChatPelanggan()
        {
            InitializeComponent();
        }

        private void updateChat()
        {
            chat = Program.conn.ExecuteDataTable("SELECT * FROM chat ORDER BY timestamp ASC");
            listChat.Items.Clear();
            // Khusus operator, tandai semua sebagai terbaca
            Program.conn.ExecuteNonQuery("UPDATE Chat SET dibaca='1'");

            for (int i = 0; i < chat.Rows.Count; i++)
            {
                DateTime timeStamp = DateTime.Parse(chat.Rows[i].ItemArray[1].ToString());
                string toChat = timeStamp.Date + " - " + timeStamp.Hour + ":" + timeStamp.Minute + ":" + timeStamp.Second + " ";
                int sender = Int16.Parse(chat.Rows[i].ItemArray[2].ToString());
                if (sender == 0)
                {
                    toChat += "[OPERATOR] ";
                }
                else
                {
                    toChat += "[PELANGGAN] ";
                }
               
                toChat += chat.Rows[i].ItemArray[3].ToString();

                listChat.Items.Add(toChat);

                

            }
        }

        private void sendChat(string toSend)
        {
            int idChat;

            // Dapatkan idChat sebelumnya
            if (chat.Rows.Count > 0)
            {
                idChat = Int16.Parse(chat.Rows[chat.Rows.Count - 1].ItemArray[0].ToString());
                idChat++;
            }
            else
            {
                idChat = 0;
            }


            // Kirim chat
            toSend = Program.escapeQuoteSQL(toSend);
            Program.conn.ExecuteNonQuery("INSERT INTO chat VALUES ('" + idChat + "',sysdate,'0','" + toSend + "','1')");
        }

        private void frmChatPelanggan_Load(object sender, EventArgs e)
        {
            updateChat();
        }

        private void btnKirim_Click(object sender, EventArgs e)
        {
            sendChat(txtChat.Text);
            txtChat.Text = "";
            updateChat();
        }

        private void tmrChat_Tick(object sender, EventArgs e)
        {
            updateChat();
        }

        private void btnBersihkan_Click(object sender, EventArgs e)
        {
            DialogResult jawaban = MessageBox.Show("Yakin semua chat akan dibersihkan?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawaban == System.Windows.Forms.DialogResult.Yes)
            {
                Program.conn.ExecuteNonQuery("DELETE FROM chat");
                updateChat();
            }
        }
    }
}
