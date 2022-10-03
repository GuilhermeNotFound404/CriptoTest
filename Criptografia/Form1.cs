            using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

            namespace Criptografia
            {
                public partial class Form1 : Form
                {

                    string chave = "eliasnechar";
                    byte[] salto = new byte[]{0x6e, 0x49, 0x61, 0x76, 0x20, 0x4d,
                                              0x76, 0x65, 0x64, 0x65, 0x76, 0x65,
                                              0x64 };
                    public Form1()
                    {
                        InitializeComponent();
                    }

                    private void BtnLimpar_Click(object sender, EventArgs e)
                    {
                        TxtCriptografado.Text = String.Empty;
                        TxtCriptografar.Text = String.Empty;
                        TxtDesceiptografado.Text = String.Empty;

                    }

                    private void BtnCriptografar_Click(object sender, EventArgs e)
                    {
                        if (string.IsNullOrWhiteSpace(TxtCriptografar.Text))
                        {
                            MessageBox.Show("Informe o texto para ser criptografado.","Criptografar texto", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                            TxtCriptografar.Focus();
                            return;
                        }

                        TxtCriptografado.Text = Criptografar(TxtCriptografar.Text, chave, salto);
                        TxtDesceiptografado.Text = Descriptografar(TxtCriptografado.Text, chave, salto);
                     }

                    public string Criptografar(string texto, string chave, byte[] salto) 
                    {

                        byte[] bytesBuff = Encoding.Unicode.GetBytes(texto);
                        using (Aes aes = Aes.Create())
                        {
                            Rfc2898DeriveBytes cripto = new Rfc2898DeriveBytes(chave, salto);

                            aes.Key = cripto.GetBytes(32);
                            aes.IV = cripto.GetBytes(16);

                            using (MemoryStream mStream = new MemoryStream())
                            {
                                using (CryptoStream cStream = new CryptoStream(mStream,
                                    aes.CreateEncryptor(),
                                    CryptoStreamMode.Write))
                                {
                                    cStream.Write(bytesBuff, 0, bytesBuff.Length);
                                    cStream.Close();
                                }

                                texto = Convert.ToBase64String(mStream.ToArray());

                            }
                        }
                        return texto;
                    }


                    public string Descriptografar(string texto, string chave, byte[] salto)
                    {
                        texto = texto.Replace(" ", "+");
                        byte[] bytesBuff = Convert.FromBase64String(texto);

                        using (Aes aes = Aes.Create())
                        {
                            Rfc2898DeriveBytes cripto = new Rfc2898DeriveBytes(chave, salto);

                            aes.Key = cripto.GetBytes(32);
                            aes.IV = cripto.GetBytes(16);

                            using (MemoryStream mStream = new MemoryStream())
                            {
                                using (CryptoStream cStream = new CryptoStream(mStream,
                                                                               aes.CreateDecryptor(),
                                                                               CryptoStreamMode.Write))
                                {
                                    cStream.Write(bytesBuff, 0, bytesBuff.Length);
                                    cStream.Close();
                                }

                                texto = Encoding.Unicode.GetString(mStream.ToArray());
                            }
                        }
                        return texto;
                    }
     

                    private void Form1_Load(object sender, EventArgs e)
                    {
                      

                    }
                }
            }
