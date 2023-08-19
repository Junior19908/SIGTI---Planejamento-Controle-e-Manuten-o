using MetroFramework;
using MetroFramework.Components;
using SIGT___PCM.Conexoes;
using System;

namespace SIGT___PCM.Tema
{
    public static class TemaGeralPrograma
    {
        public static void SetPurpleStyle(MetroStyleManager styleManager)
        {
            if (styleManager.Style == MetroFramework.MetroColorStyle.Default)
            {
                ClassDadosGet.Tema = "Default";
            }
            else if(styleManager.Style == MetroFramework.MetroColorStyle.Black)
            {
                ClassDadosGet.Tema = "Preto";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.White)
            {
                ClassDadosGet.Tema = "Branco";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Silver)
            {
                ClassDadosGet.Tema = "Prata";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Blue)
            {
                ClassDadosGet.Tema = "Azul";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Green)
            {
                ClassDadosGet.Tema = "Verde";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Lime)
            {
                ClassDadosGet.Tema = "Limão";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Teal)
            {
                ClassDadosGet.Tema = "Verde Azulado";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Orange)
            {
                ClassDadosGet.Tema = "Laranja";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Brown)
            {
                ClassDadosGet.Tema = "Marrom";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Pink)
            {
                ClassDadosGet.Tema = "Rosa";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Magenta)
            {
                ClassDadosGet.Tema = "Magenta";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Purple)
            {
                ClassDadosGet.Tema = "Roxo";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Red)
            {
                ClassDadosGet.Tema = "Vermelho";
            }
            else if (styleManager.Style == MetroFramework.MetroColorStyle.Yellow)
            {
                ClassDadosGet.Tema = "Amarelo";
            }
        }
    }
}
