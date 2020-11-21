﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace capaNegocio
{
    public static class Utils
    {
        public static Object formulario ;
        public static bool CheckString(string txt)
        {

            return string.IsNullOrEmpty(txt.Trim());
        }

		public static bool ValidaRut(string rut)
		{
			rut = rut.Replace(".", "").ToUpper();
			Regex expresion = new Regex("^([0-9]+-[0-9K])$");
			string dv = rut.Substring(rut.Length - 1, 1);
			if (!expresion.IsMatch(rut))
			{
				return false;
			}
			char[] charCorte = { '-' };
			string[] rutTemp = rut.Split(charCorte);
			if (dv != Digito(int.Parse(rutTemp[0])))
			{
				return false;
			}
			return true;
		}

		public static bool ValidaRut(string rut, string dv)
		{
			return ValidaRut(rut + "-" + dv);
		}
		public static string Digito(int rut)
		{
			int suma = 0;
			int multiplicador = 1;
			while (rut != 0)
			{
				multiplicador++;
				if (multiplicador == 8)
					multiplicador = 2;
				suma += (rut % 10) * multiplicador;
				rut = rut / 10;
			}
			suma = 11 - (suma % 11);
			if (suma == 11)
			{
				return "0";
			}
			else if (suma == 10)
			{
				return "K";
			}
			else
			{
				return suma.ToString();
			}
		}

	}
}
