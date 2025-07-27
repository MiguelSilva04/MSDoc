using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DataAccess;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        UserDao userDao = new UserDao();
        //Attributes
        private int idUser;
        private string LoginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;
        private byte[] image;
        //Constructors
        public UserModel(int idUser, string LoginName, string password, string firstName, string lastName, string position, string email)
        {
            this.idUser = idUser;
            this.LoginName = LoginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.email = email;
        }
        public UserModel()
        {
        }
        //Methods
        public string editUserProfile()
        {
            try
            {
                userDao.editProfile(idUser, LoginName, password, firstName, lastName, email);
                LoginUser(LoginName, password);
                return "Your profile has been successfully updated";
            }
            catch (Exception ex)
            {
                return "Username is already registered, try another";
            }
        }

        public bool LoginUser(string user, string pass)
        {
            return userDao.Login(user, pass);

        }
        public string recoverPassword(string userRequesting)
        {
            return userDao.recoverPassword(userRequesting);
        }
        public void AnyMethod()
        {
            //Security and Permissions
            if (UserCache.Position == Positions.Admin)
            {
                //Codes
            }
            if (UserCache.Position == Positions.Aluno || UserCache.Position == Positions.Professor)
            {
                //Codes
            }
        }
    }
}