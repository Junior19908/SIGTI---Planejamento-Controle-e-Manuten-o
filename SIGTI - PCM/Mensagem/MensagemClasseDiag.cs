using SIGT___PCM.Conexoes;
using System.Drawing;

namespace SIGT___PCM.Mensagem
{
    internal class MensagemClasseDiag
    {
        public void MostrarMensagemPersonalizadaErroAusente(string cod)
        {
            Icon seuIcone = Properties.Resources.SIGT_LOGO_ICO1;
            Image suaLogo = Properties.Resources.document;
            string mensagem = "Prezado "+ ClassDadosGet.Usuario.ToUpper() +",\n\nIdentificamos que o equipamento de número " + cod + " pertencente à sua empresa, não possui ficha de cadastro registrada no nosso sistema.\n\nPor favor, tome as devidas providências para realizar o cadastro necessário. Caso necessite de assistência ou mais informações, nossa equipe está à disposição para prestar suporte.\n\nAgradecemos pela compreensão.\n\nAtenciosamente,\n[SIGT - Sistemas Integrados TI]";
            string titulo = "SIGT - Aviso de Ficha de Equipamento Ausente";
            MensagemClasse customMessageBox = new MensagemClasse(mensagem, titulo, suaLogo, seuIcone);
            customMessageBox.ShowDialog();
        }
        public void MostrarMensagemPersonalizadaSelecaoDias()
        {
            Icon seuIcone = Properties.Resources.SIGT_LOGO_ICO1;
            Image suaLogo = Properties.Resources.document;
            string mensagem = "Prezado "+ ClassDadosGet.Usuario.ToUpper() +",\n\n"
                                                + "Por favor, observe que é necessário marcar pelo menos um dia de trabalho para continuar.\n"
                                                + "Sua colaboração é fundamental para garantir a precisão de nossos registros.\n\n"
                                                + "Agradecemos pela sua atenção e cooperação.\n\n"
                                                + "Atenciosamente,\n"
                                                + "[SIGT - Sistemas Integrados de TI]";
            string titulo = "Aviso - Seleção de Dias de Trabalho";
            MensagemClasse customMessageBox = new MensagemClasse(mensagem, titulo, suaLogo, seuIcone);
            customMessageBox.ShowDialog();
        }
        public void MostrarMensagemPersonalizadaInseridaCorretamente(string cod, string form)
        {
            Icon seuIcone = Properties.Resources.SIGT_LOGO_ICO1;
            Image suaLogo = Properties.Resources.document;
            string mensagem = "Prezado "+ ClassDadosGet.Usuario.ToUpper() + ",\n\nO registro do "+ form +" de número " + cod + " foi adicionado com sucesso ao sistema.\n\nAgradecemos por sua colaboração e estamos à disposição para qualquer assistência adicional.\n\nAtenciosamente,\n[SIGT - Sistemas Integrados TI]";
            string titulo = "SIGT - Registro do equipamento incluído com sucesso";
            MensagemClasse customMessageBox = new MensagemClasse(mensagem, titulo, suaLogo, seuIcone);
            customMessageBox.ShowDialog();
        }
        public void MostrarMensagemPersonalizadaInseridaErro(string form)
        {
            Icon seuIcone = Properties.Resources.SIGT_LOGO_ICO1;
            Image suaLogo = Properties.Resources.document;
            string mensagem = "Prezado "+ ClassDadosGet.Usuario.ToUpper() + ",\n\nOcorreu um erro durante a tentativa de inserção do "+ form +". Por favor, verifique os dados fornecidos e tente novamente. Caso precise de assistência ou tenha alguma dúvida, nossa equipe está à disposição para prestar suporte.\n\nAgradecemos pela compreensão.\n\nAtenciosamente,\n[SIGT - Sistemas Integrados TI]";
            string titulo = "SIGT - Erro na Inserção do Equipamento";
            MensagemClasse customMessageBox = new MensagemClasse(mensagem, titulo, suaLogo, seuIcone);
            customMessageBox.ShowDialog();
        }
    }
}
