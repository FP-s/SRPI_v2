﻿using System;

namespace SRPI { 
    public class Controller {

        Model model;
        View view;
                
        public Controller()	{

            //iniciar componentes Model e View
            model = new Model();
            view = new View();
            
	    }

        public void IniciarPrograma() {

            //iniciar programa com a janela de login
            view.ApresentarLogin();

        }

        public void IntroduzirLogin(string utilizador, string password) {

            //passa ao model o utilizador e a password para verificação
            if(model.VerificarLogin(utilizador, password)) {

                //se o login for verificado, apresenta a janela de relatorio através da View
                view.ApresentarRelatorio();

            }
        }
    }
}
