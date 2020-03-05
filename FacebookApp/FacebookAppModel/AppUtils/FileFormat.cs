using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FacebookApp
{
    public class FileFormat
    {
        public FileFormat(UserProxy i_LoggedInUser)
        {
            this.LoggedInUser = i_LoggedInUser;
            this.ChosenProperties = new List<PropertiesOptions.ePropertiesOptions>();
            this.OptionalPropreties = new List<PropertiesOptions.ePropertiesOptions>();
            this.initOptionalProperties();
        }

        public List<PropertiesOptions.ePropertiesOptions> ChosenProperties { get; set; }

        public List<PropertiesOptions.ePropertiesOptions> OptionalPropreties { get; set; }

        public UserProxy LoggedInUser { get; set; }

        public override string ToString()
        {
            StringBuilder propertiesStringToFile = new StringBuilder();
            foreach (PropertiesOptions.ePropertiesOptions propChosen in this.ChosenProperties)
            {
                this.addToString(propChosen, propertiesStringToFile);
            }

            return propertiesStringToFile.ToString();
        }

        private void initOptionalProperties()
        {
            foreach (PropertiesOptions.ePropertiesOptions propertyOption in (PropertiesOptions.ePropertiesOptions[])Enum.GetValues(typeof(PropertiesOptions.ePropertiesOptions)))
            {
                this.OptionalPropreties.Add(propertyOption);
            }
        }

        private void addToString(PropertiesOptions.ePropertiesOptions i_PropChosen, StringBuilder i_UserFileFormat)
        {
            switch (i_PropChosen)
            {   
                case PropertiesOptions.ePropertiesOptions.Birthday:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.Birthday);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.About:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.About);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.Email:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.Email);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.Gender:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.Gender);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.Id:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.Id);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.Link:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.Link);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.Name:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.Name);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.RelationshipStatus:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.RelationshipStatus);
                    i_UserFileFormat.AppendLine();
                    break;
                case PropertiesOptions.ePropertiesOptions.Religion:
                    i_UserFileFormat.Append(this.LoggedInUser.LoggedInUser.Religion);
                    i_UserFileFormat.AppendLine();
                    break;
                default:
                    break;
            }
        }
    }
}
