using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using System.Net;
using System.IO;

//including basics libs n stuff

namespace CryptoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        //those imports from windows DLLs are needed to
        //move the app smoothly around the screen

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
            //same as above
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
            //handler for exit button
        }

        private void check_coin_Click(object sender, EventArgs e)
        {
            string api_url = @"https://api.coingecko.com/api/v3/coins/" + coin_id.Text;
            //we add provided coin name to the url to perfrom a GET request
            try
            {
                WebRequest r;
                r = WebRequest.Create(api_url);
                Stream str;
                str = r.GetResponse().GetResponseStream();
                StreamReader or = new StreamReader(str);
                string stuff = or.ReadToEnd();
                dynamic json = JsonConvert.DeserializeObject(stuff);
                str.Close();
                or.Close();
                //doing actuall request and parsing JSON response to
                //dynamic data type
                coin_name.Text = json.id;
                coin_short.Text = json.symbol;
                coin_value_usd.Text = json.market_data.current_price.usd;
                coin_value_pln.Text = json.market_data.current_price.pln;
                error_message.Text = "";
                //if the request was fine,we assign specific values
                //to the read-only textboxes and clear the error message
            }
            catch (Exception err)
            {
                error_message.Text = err.Message;
                coin_name.Text = "";
                coin_short.Text = "";
                coin_value_usd.Text = "";
                coin_value_pln.Text = "";
                /*
                    if something got fucked,we clear the data from
                    previous requests and display the error message.this is
                    very shitty way of doing that,but i dont care.
                 */
            }
        }
    }
}
