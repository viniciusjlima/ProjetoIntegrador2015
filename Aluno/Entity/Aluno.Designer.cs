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
using System.Diagnostics.CodeAnalysis;

[assembly: EdmSchemaAttribute()]
namespace Aluno.Entity
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [ExcludeFromCodeCoverage]
    public partial class AlunoEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AlunoEntities object using the connection string found in the 'AlunoEntities' section of the application configuration file.
        /// </summary>
        public AlunoEntities() : base("name=AlunoEntities", "AlunoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AlunoEntities object.
        /// </summary>
        public AlunoEntities(string connectionString) : base(connectionString, "AlunoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AlunoEntities object.
        /// </summary>
        public AlunoEntities(EntityConnection connection) : base(connection, "AlunoEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<aluno> Aluno
        {
            get
            {
                if ((_Aluno == null))
                {
                    _Aluno = base.CreateObjectSet<aluno>("Aluno");
                }
                return _Aluno;
            }
        }
        private ObjectSet<aluno> _Aluno;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Professor> Professor
        {
            get
            {
                if ((_Professor == null))
                {
                    _Professor = base.CreateObjectSet<Professor>("Professor");
                }
                return _Professor;
            }
        }
        private ObjectSet<Professor> _Professor;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Aluno EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAluno(aluno aluno)
        {
            base.AddObject("Aluno", aluno);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Professor EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProfessor(Professor professor)
        {
            base.AddObject("Professor", professor);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AlunoModel", Name="aluno")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class aluno : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new aluno object.
        /// </summary>
        /// <param name="idAluno">Initial value of the IdAluno property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        /// <param name="cPF">Initial value of the CPF property.</param>
        /// <param name="matricula">Initial value of the Matricula property.</param>
        public static aluno Createaluno(global::System.Int32 idAluno, global::System.String nome, global::System.String cPF, global::System.String matricula)
        {
            aluno aluno = new aluno();
            aluno.IdAluno = idAluno;
            aluno.Nome = nome;
            aluno.CPF = cPF;
            aluno.Matricula = matricula;
            return aluno;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdAluno
        {
            get
            {
                return _IdAluno;
            }
            set
            {
                if (_IdAluno != value)
                {
                    OnIdAlunoChanging(value);
                    ReportPropertyChanging("IdAluno");
                    _IdAluno = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdAluno");
                    OnIdAlunoChanged();
                }
            }
        }
        private global::System.Int32 _IdAluno;
        partial void OnIdAlunoChanging(global::System.Int32 value);
        partial void OnIdAlunoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CPF
        {
            get
            {
                return _CPF;
            }
            set
            {
                OnCPFChanging(value);
                ReportPropertyChanging("CPF");
                _CPF = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("CPF");
                OnCPFChanged();
            }
        }
        private global::System.String _CPF;
        partial void OnCPFChanging(global::System.String value);
        partial void OnCPFChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Matricula
        {
            get
            {
                return _Matricula;
            }
            set
            {
                OnMatriculaChanging(value);
                ReportPropertyChanging("Matricula");
                _Matricula = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Matricula");
                OnMatriculaChanged();
            }
        }
        private global::System.String _Matricula;
        partial void OnMatriculaChanging(global::System.String value);
        partial void OnMatriculaChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AlunoModel", Name="Professor")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Professor : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Professor object.
        /// </summary>
        /// <param name="idProfessor">Initial value of the idProfessor property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        /// <param name="especializacao">Initial value of the Especializacao property.</param>
        /// <param name="materia">Initial value of the Materia property.</param>
        public static Professor CreateProfessor(global::System.Int32 idProfessor, global::System.String nome, global::System.String especializacao, global::System.String materia)
        {
            Professor professor = new Professor();
            professor.idProfessor = idProfessor;
            professor.Nome = nome;
            professor.Especializacao = especializacao;
            professor.Materia = materia;
            return professor;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 idProfessor
        {
            get
            {
                return _idProfessor;
            }
            set
            {
                if (_idProfessor != value)
                {
                    OnidProfessorChanging(value);
                    ReportPropertyChanging("idProfessor");
                    _idProfessor = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("idProfessor");
                    OnidProfessorChanged();
                }
            }
        }
        private global::System.Int32 _idProfessor;
        partial void OnidProfessorChanging(global::System.Int32 value);
        partial void OnidProfessorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                OnNomeChanging(value);
                ReportPropertyChanging("Nome");
                _Nome = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nome");
                OnNomeChanged();
            }
        }
        private global::System.String _Nome;
        partial void OnNomeChanging(global::System.String value);
        partial void OnNomeChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Especializacao
        {
            get
            {
                return _Especializacao;
            }
            set
            {
                OnEspecializacaoChanging(value);
                ReportPropertyChanging("Especializacao");
                _Especializacao = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Especializacao");
                OnEspecializacaoChanged();
            }
        }
        private global::System.String _Especializacao;
        partial void OnEspecializacaoChanging(global::System.String value);
        partial void OnEspecializacaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Materia
        {
            get
            {
                return _Materia;
            }
            set
            {
                OnMateriaChanging(value);
                ReportPropertyChanging("Materia");
                _Materia = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Materia");
                OnMateriaChanged();
            }
        }
        private global::System.String _Materia;
        partial void OnMateriaChanging(global::System.String value);
        partial void OnMateriaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Graduacao
        {
            get
            {
                return _Graduacao;
            }
            set
            {
                OnGraduacaoChanging(value);
                ReportPropertyChanging("Graduacao");
                _Graduacao = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Graduacao");
                OnGraduacaoChanged();
            }
        }
        private global::System.String _Graduacao;
        partial void OnGraduacaoChanging(global::System.String value);
        partial void OnGraduacaoChanged();

        #endregion

    
    }

    #endregion

    
}
