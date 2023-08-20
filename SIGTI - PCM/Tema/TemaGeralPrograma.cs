using MetroFramework;
using MetroFramework.Components;
using SIGT___PCM.Conexoes;
using System;
using System.Data.OleDb;

namespace SIGT___PCM.Tema
{
    public static class TemaGeralPrograma
    {
        public static void SetPurpleStyle(MetroStyleManager styleManager)
        {
            styleManager.Style = ClassDadosGet.TemaUser;
            if (styleManager.Style == MetroColorStyle.Default)
            {
                ClassDadosGet.Tema = "Default";
            }
            else if(styleManager.Style == MetroColorStyle.Black)
            {
                ClassDadosGet.Tema = "Preto";
            }
            else if (styleManager.Style == MetroColorStyle.White)
            {
                ClassDadosGet.Tema = "Branco";
            }
            else if (styleManager.Style == MetroColorStyle.Silver)
            {
                ClassDadosGet.Tema = "Prata";
            }
            else if (styleManager.Style == MetroColorStyle.Blue)
            {
                ClassDadosGet.Tema = "Azul";
            }
            else if (styleManager.Style == MetroColorStyle.Green)
            {
                ClassDadosGet.Tema = "Verde";
            }
            else if (styleManager.Style == MetroColorStyle.Lime)
            {
                ClassDadosGet.Tema = "Limão";
            }
            else if (styleManager.Style == MetroColorStyle.Teal)
            {
                ClassDadosGet.Tema = "Verde Azulado";
            }
            else if (styleManager.Style == MetroColorStyle.Orange)
            {
                ClassDadosGet.Tema = "Laranja";
            }
            else if (styleManager.Style == MetroColorStyle.Brown)
            {
                ClassDadosGet.Tema = "Marrom";
            }
            else if (styleManager.Style == MetroColorStyle.Pink)
            {
                ClassDadosGet.Tema = "Rosa";
            }
            else if (styleManager.Style == MetroColorStyle.Magenta)
            {
                ClassDadosGet.Tema = "Magenta";
            }
            else if (styleManager.Style == MetroColorStyle.Purple)
            {
                ClassDadosGet.Tema = "Roxo";
            }
            else if (styleManager.Style == MetroColorStyle.Red)
            {
                ClassDadosGet.Tema = "Vermelho";
            }
            else if (styleManager.Style == MetroColorStyle.Yellow)
            {
                ClassDadosGet.Tema = "Amarelo";
            }
        }
    }
}
