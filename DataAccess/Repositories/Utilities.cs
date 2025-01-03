﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DataAccess.Repositories
{
    public abstract class Utilities<T>
    {

        public static void FillCombo(List<T> values, Array arr, System.Windows.Forms.ComboBox combo)
        {
            combo.DataSource = values;
            combo.DisplayMember = arr.GetValue(1).ToString();
            combo.ValueMember = arr.GetValue(0).ToString();
            combo.SelectedIndex = -1;
        }
        public static List<T> GetValues(DataGridView dataGridView)
        {
           T [] Columns = new T[dataGridView.Columns.Count];
            dataGridView.Columns.CopyTo(Columns, 0);
            return Columns. ToList().Where(x => !string.IsNullOrEmpty(x.GetType()
                                    .GetRuntimeProperties().FirstOrDefault(z => z.Name == "Name")
                                    .GetValue(x).ToString()))
                                    .ToList();             
        }
        public static void FillCombo(List<T> values,ComboBox combo)
        {
            combo.Items.Clear();              
            foreach (var item in values) 
            {
                PropertyInfo propertyInfo = item.GetType().GetRuntimeProperties()
                                                          .FirstOrDefault(x=>x.Name=="Name");
                combo.Items.Add(propertyInfo.GetValue(item).ToString());                
            }
            combo.SelectedIndex = 0;
        }
        public static bool GetValue(T z, string field, string value)
        {
            return z.GetType().GetProperty(field).GetValue(z)
                              .ToString().Contains(value);
        }

        public static string Encriptar(T cadenaAencriptar)
        {
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar.ToString());
            return Convert.ToBase64String(encryted);
        }
        public static bool ValidarEmail(T email)
        {
            string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            return !Regex.IsMatch(email.ToString(), expresion) ? false :
                   Regex.Replace(email.ToString(), expresion, string.Empty).Length == 0;
        }
      public static   StreamWriter Createfile(T path,T file )
        {
            try
            {
                CreateDirectory(path);
                if (File.Exists(path.ToString ()+file.ToString()))
                {
                    File.Delete(path.ToString() + file.ToString());
                }
                FileStream fs = File.Create(path.ToString()  + file.ToString ());
                StreamWriter sWriter = new(fs);
                return sWriter;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void CreateDirectory(T path)
        {
            if (!Directory.Exists(path.ToString ()))
            {
                Directory.CreateDirectory(path.ToString());
            }
        }
        public static StreamReader ReadFile(T path, T file)
        {
            try
            {
                StreamReader sReader = null;
                if (File.Exists(path.ToString() + file.ToString()))
                {
                    FileStream fs = File.OpenRead(path.ToString() + file.ToString ());
                    sReader = new StreamReader(fs);
                }
                return sReader;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static void DeleteFile(T path, T file)
        {
            try
            {

                if (File.Exists(path.ToString() + file.ToString()))
                    File.Delete(path.ToString() + file.ToString());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
