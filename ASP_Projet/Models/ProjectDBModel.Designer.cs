﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace ASP_Projet.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class ProjectDBModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new ProjectDBModelContainer object using the connection string found in the 'ProjectDBModelContainer' section of the application configuration file.
        /// </summary>
        public ProjectDBModelContainer() : base("name=ProjectDBModelContainer", "ProjectDBModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProjectDBModelContainer object.
        /// </summary>
        public ProjectDBModelContainer(string connectionString) : base(connectionString, "ProjectDBModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new ProjectDBModelContainer object.
        /// </summary>
        public ProjectDBModelContainer(EntityConnection connection) : base(connection, "ProjectDBModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
    }

    #endregion

}
