using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    
        public static class Utilities
        { // Método que valida si un campo textbox tiene un valor correcto
          //Recibimos como parametro el control textbox y el tipo de dato que queremos validar
            public static Boolean ValidateField(TextBox campo, string tipo)
            {
                switch (tipo)
                {
                    case "string":
                        if (campo.Text != "")
                        {
                            try
                            {
                                Convert.ToString(campo.Text);
                                campo.BackColor = System.Drawing.Color.White;
                                return true;
                            }
                            catch (Exception)
                            {
                                campo.BackColor = System.Drawing.Color.OrangeRed;
                                return false;
                            }
                        }
                        else
                        {
                            campo.BackColor = System.Drawing.Color.OrangeRed;
                            return false;
                        }




                    case "decimal":
                        try
                        {
                            Convert.ToDecimal(campo.Text);
                            campo.BackColor = System.Drawing.Color.White;
                            return true;
                        }
                        catch (Exception)
                        {
                            campo.BackColor = System.Drawing.Color.OrangeRed;
                            return false;
                        }


                    case "int":
                        try
                        {
                            Convert.ToInt32(campo.Text);
                            campo.BackColor = System.Drawing.Color.White;
                            return true;
                        }
                        catch (Exception)
                        {
                            campo.BackColor = System.Drawing.Color.OrangeRed;
                            return false;
                        }

                    default:
                        return false;
                }
            }

        }
    }

