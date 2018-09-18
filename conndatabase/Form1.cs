﻿using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using conndatabase.data;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;

namespace conndatabase
{
   
    public partial class Form1 : Form
    {
        private connect con;
        public Form1()
        {
            InitializeComponent();

            loadIp();
        }
        private static string GetARPResult()
        {
            Process p = null;
            string output = string.Empty;

            try
            {
                p = Process.Start(new ProcessStartInfo("arp", "-a")
                {
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                });

                output = p.StandardOutput.ReadToEnd();

                p.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("IPInfo: Error Retrieving 'arp -a' Results", ex);
            }
            finally
            {
                if (p != null)
                {
                    p.Close();
                }
            }

            return output;
        }
        private void loadIp()
        {
            try
            {

                foreach (var arp in GetARPResult().Split(new char[] { '\n', '\r' }))
                {
                    if (!string.IsNullOrEmpty(arp))
                    {
                        var pieces = (from piece in arp.Split(new char[] { ' ', '\t' })
                                      where !string.IsNullOrEmpty(piece)
                                      select piece).ToArray();
                        if (pieces.Length == 3 && pieces[2] == "dynamic")
                        {
                            cmbSeverName.Items.Add(pieces[0]);
                        }
                    }
                }
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        cmbSeverName.Text = ip.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception("IPInfo: Error Parsing 'arp -a' results", ex);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            connect cnn = new connect(cmbSeverName.Text, txtUserName.Text, txtPass.Text);
            cnn.conn();
            con = cnn;
            cmbDataName.DataSource = cnn.getDataName();
        }

        private void cmbDataName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbTableName.Items.Clear();
            if (cmbDataName.SelectedItem.ToString()!="")
            {
                foreach(var a in con.getTableName(cmbDataName.SelectedItem.ToString()))
                {
                    cmbTableName.Items.Add(a.ToString()) ;
                }
                
            }
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = con.getDataTable(cmbTableName.Text,cmbDataName.Text);
        }
    }
}