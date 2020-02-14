using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using unoM.Models;

namespace unoM.Controllers
{
    class Controller1
    {
        private View1 aView;
        private Model1 aModel;
        private ResourceManager imageManager;
        private ResourceManager languageManger;

        public View1 AView { get => aView; set => aView = value; }
        internal Model1 AModel { get => aModel; set => aModel = value; }
        public ResourceManager ImageManager { get => imageManager; set => imageManager = value; }
        public ResourceManager LanguageManger { get => languageManger; set => languageManger = value; }

        public Controller1(Model1 _aModel, View1 _aView)
        {
            imageManager = new ResourceManager(typeof(Resources.Images.images));
            languageManger = new ResourceManager(typeof(Resources.i18n.en));

            aModel = _aModel;
            aView = _aView;

            aView.AController = this;
        }        

        public Image GetImage(string _id)
        {
            return (Image)imageManager.GetObject(_id);
        }

        public Image ResizeImage(string _id, Size _size)
        {
            return (Image)(new Bitmap(GetImage(_id), _size));
        }

        public Icon GetIcon(string _id)
        {
            return (Icon)imageManager.GetObject(_id);
        }

        public string GetText(string _id)
        {
            return languageManger.GetString(_id);
        }

        public void ChangeLanguage(string _langId)
        {
            switch (_langId)
            {
                case "frFlag":
                    languageManger = new ResourceManager(typeof(Resources.i18n.fr));
                    break;
                case "enFlag":
                default:
                    languageManger = new ResourceManager(typeof(Resources.i18n.en));
                    break;
            }
        }

        internal bool CheckUser(string pseudo, string password)
        {
            return aModel.CheckUser(pseudo, password);
        }

        internal User GetCurrentUser()
        {
            return aModel.GetCurrentUser();
        }

        internal void CreateUser(string _pseudo, string _password, string _email)
        {
            aModel.CreateUser(_pseudo, _password, _email);
        }

        internal bool MatchPseudo(string _pseudo)
        {
            return Model1.MatchPseudo(_pseudo);
        }

        internal bool MatchPassword(string _password)
        {
            return Model1.MatchPassword(_password);
        }        

        internal bool MatchEmail(string text)
        {
            return Model1.MatchEmail(text);
        }

        internal bool CheckEmail(string text)
        {
            return aModel.CheckEmail(text);
        }

        internal string SendPassword(string text)
        {
            return aModel.SendPassword(text);
        }        
    }
}
