﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("EcommerceModel", "FK_PessoaPedido", "Pessoa", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EntityDataAccess.EPessoa), "Pedido", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityDataAccess.EPedido), true)]
[assembly: EdmRelationshipAttribute("EcommerceModel", "FK_PessoaUsuario", "Pessoa", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EntityDataAccess.EPessoa), "Usuario", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityDataAccess.EUsuario), true)]
[assembly: EdmRelationshipAttribute("EcommerceModel", "PedidoProduto", "Pedido", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityDataAccess.EPedido), "Produto", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityDataAccess.EProduto))]

#endregion

namespace EntityDataAccess
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class Ecommerce2Entities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new Ecommerce2Entities object using the connection string found in the 'Ecommerce2Entities' section of the application configuration file.
        /// </summary>
        public Ecommerce2Entities() : base("name=Ecommerce2Entities", "Ecommerce2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Ecommerce2Entities object.
        /// </summary>
        public Ecommerce2Entities(string connectionString) : base(connectionString, "Ecommerce2Entities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new Ecommerce2Entities object.
        /// </summary>
        public Ecommerce2Entities(EntityConnection connection) : base(connection, "Ecommerce2Entities")
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
        public ObjectSet<EPedido> Pedido
        {
            get
            {
                if ((_Pedido == null))
                {
                    _Pedido = base.CreateObjectSet<EPedido>("Pedido");
                }
                return _Pedido;
            }
        }
        private ObjectSet<EPedido> _Pedido;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EPessoa> Pessoa
        {
            get
            {
                if ((_Pessoa == null))
                {
                    _Pessoa = base.CreateObjectSet<EPessoa>("Pessoa");
                }
                return _Pessoa;
            }
        }
        private ObjectSet<EPessoa> _Pessoa;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EProduto> Produto
        {
            get
            {
                if ((_Produto == null))
                {
                    _Produto = base.CreateObjectSet<EProduto>("Produto");
                }
                return _Produto;
            }
        }
        private ObjectSet<EProduto> _Produto;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<EUsuario> Usuario
        {
            get
            {
                if ((_Usuario == null))
                {
                    _Usuario = base.CreateObjectSet<EUsuario>("Usuario");
                }
                return _Usuario;
            }
        }
        private ObjectSet<EUsuario> _Usuario;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pedido EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPedido(EPedido ePedido)
        {
            base.AddObject("Pedido", ePedido);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Pessoa EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToPessoa(EPessoa ePessoa)
        {
            base.AddObject("Pessoa", ePessoa);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Produto EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToProduto(EProduto eProduto)
        {
            base.AddObject("Produto", eProduto);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Usuario EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToUsuario(EUsuario eUsuario)
        {
            base.AddObject("Usuario", eUsuario);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EcommerceModel", Name="EPedido")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EPedido : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EPedido object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="data">Initial value of the Data property.</param>
        /// <param name="pessoaId">Initial value of the PessoaId property.</param>
        public static EPedido CreateEPedido(global::System.Int32 id, global::System.DateTime data, global::System.Int32 pessoaId)
        {
            EPedido ePedido = new EPedido();
            ePedido.Id = id;
            ePedido.Data = data;
            ePedido.PessoaId = pessoaId;
            return ePedido;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime Data
        {
            get
            {
                return _Data;
            }
            set
            {
                OnDataChanging(value);
                ReportPropertyChanging("Data");
                _Data = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Data");
                OnDataChanged();
            }
        }
        private global::System.DateTime _Data;
        partial void OnDataChanging(global::System.DateTime value);
        partial void OnDataChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PessoaId
        {
            get
            {
                return _PessoaId;
            }
            set
            {
                OnPessoaIdChanging(value);
                ReportPropertyChanging("PessoaId");
                _PessoaId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PessoaId");
                OnPessoaIdChanged();
            }
        }
        private global::System.Int32 _PessoaId;
        partial void OnPessoaIdChanging(global::System.Int32 value);
        partial void OnPessoaIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EcommerceModel", "FK_PessoaPedido", "Pessoa")]
        public EPessoa Pessoa
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EPessoa>("EcommerceModel.FK_PessoaPedido", "Pessoa").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EPessoa>("EcommerceModel.FK_PessoaPedido", "Pessoa").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EPessoa> PessoaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EPessoa>("EcommerceModel.FK_PessoaPedido", "Pessoa");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EPessoa>("EcommerceModel.FK_PessoaPedido", "Pessoa", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EcommerceModel", "PedidoProduto", "Produto")]
        public EntityCollection<EProduto> Produto
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EProduto>("EcommerceModel.PedidoProduto", "Produto");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EProduto>("EcommerceModel.PedidoProduto", "Produto", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EcommerceModel", Name="EPessoa")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EPessoa : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EPessoa object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        /// <param name="cPF">Initial value of the CPF property.</param>
        public static EPessoa CreateEPessoa(global::System.Int32 id, global::System.String nome, global::System.String cPF)
        {
            EPessoa ePessoa = new EPessoa();
            ePessoa.Id = id;
            ePessoa.Nome = nome;
            ePessoa.CPF = cPF;
            return ePessoa;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> DataNascimento
        {
            get
            {
                return _DataNascimento;
            }
            set
            {
                OnDataNascimentoChanging(value);
                ReportPropertyChanging("DataNascimento");
                _DataNascimento = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("DataNascimento");
                OnDataNascimentoChanged();
            }
        }
        private Nullable<global::System.DateTime> _DataNascimento;
        partial void OnDataNascimentoChanging(Nullable<global::System.DateTime> value);
        partial void OnDataNascimentoChanged();
    
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
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NomeFoto
        {
            get
            {
                return _NomeFoto;
            }
            set
            {
                OnNomeFotoChanging(value);
                ReportPropertyChanging("NomeFoto");
                _NomeFoto = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NomeFoto");
                OnNomeFotoChanged();
            }
        }
        private global::System.String _NomeFoto;
        partial void OnNomeFotoChanging(global::System.String value);
        partial void OnNomeFotoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EcommerceModel", "FK_PessoaPedido", "Pedido")]
        public EntityCollection<EPedido> Pedido
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EPedido>("EcommerceModel.FK_PessoaPedido", "Pedido");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EPedido>("EcommerceModel.FK_PessoaPedido", "Pedido", value);
                }
            }
        }
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EcommerceModel", "FK_PessoaUsuario", "Usuario")]
        public EntityCollection<EUsuario> Usuario
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EUsuario>("EcommerceModel.FK_PessoaUsuario", "Usuario");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EUsuario>("EcommerceModel.FK_PessoaUsuario", "Usuario", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EcommerceModel", Name="EProduto")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EProduto : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EProduto object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="nome">Initial value of the Nome property.</param>
        /// <param name="descricao">Initial value of the Descricao property.</param>
        /// <param name="preco">Initial value of the Preco property.</param>
        /// <param name="qtdEstoque">Initial value of the QtdEstoque property.</param>
        public static EProduto CreateEProduto(global::System.Int32 id, global::System.String nome, global::System.String descricao, global::System.Decimal preco, global::System.Int32 qtdEstoque)
        {
            EProduto eProduto = new EProduto();
            eProduto.Id = id;
            eProduto.Nome = nome;
            eProduto.Descricao = descricao;
            eProduto.Preco = preco;
            eProduto.QtdEstoque = qtdEstoque;
            return eProduto;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
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
        public global::System.String Descricao
        {
            get
            {
                return _Descricao;
            }
            set
            {
                OnDescricaoChanging(value);
                ReportPropertyChanging("Descricao");
                _Descricao = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Descricao");
                OnDescricaoChanged();
            }
        }
        private global::System.String _Descricao;
        partial void OnDescricaoChanging(global::System.String value);
        partial void OnDescricaoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Decimal Preco
        {
            get
            {
                return _Preco;
            }
            set
            {
                OnPrecoChanging(value);
                ReportPropertyChanging("Preco");
                _Preco = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Preco");
                OnPrecoChanged();
            }
        }
        private global::System.Decimal _Preco;
        partial void OnPrecoChanging(global::System.Decimal value);
        partial void OnPrecoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 QtdEstoque
        {
            get
            {
                return _QtdEstoque;
            }
            set
            {
                OnQtdEstoqueChanging(value);
                ReportPropertyChanging("QtdEstoque");
                _QtdEstoque = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("QtdEstoque");
                OnQtdEstoqueChanged();
            }
        }
        private global::System.Int32 _QtdEstoque;
        partial void OnQtdEstoqueChanging(global::System.Int32 value);
        partial void OnQtdEstoqueChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> CategoriaId
        {
            get
            {
                return _CategoriaId;
            }
            set
            {
                OnCategoriaIdChanging(value);
                ReportPropertyChanging("CategoriaId");
                _CategoriaId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("CategoriaId");
                OnCategoriaIdChanged();
            }
        }
        private Nullable<global::System.Int32> _CategoriaId;
        partial void OnCategoriaIdChanging(Nullable<global::System.Int32> value);
        partial void OnCategoriaIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Foto
        {
            get
            {
                return _Foto;
            }
            set
            {
                OnFotoChanging(value);
                ReportPropertyChanging("Foto");
                _Foto = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Foto");
                OnFotoChanged();
            }
        }
        private global::System.String _Foto;
        partial void OnFotoChanging(global::System.String value);
        partial void OnFotoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EcommerceModel", "PedidoProduto", "Pedido")]
        public EntityCollection<EPedido> Pedido
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<EPedido>("EcommerceModel.PedidoProduto", "Pedido");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<EPedido>("EcommerceModel.PedidoProduto", "Pedido", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="EcommerceModel", Name="EUsuario")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class EUsuario : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new EUsuario object.
        /// </summary>
        /// <param name="id">Initial value of the Id property.</param>
        /// <param name="login">Initial value of the Login property.</param>
        /// <param name="status">Initial value of the Status property.</param>
        /// <param name="senha">Initial value of the Senha property.</param>
        /// <param name="pessoaId">Initial value of the PessoaId property.</param>
        public static EUsuario CreateEUsuario(global::System.Int32 id, global::System.String login, global::System.Boolean status, global::System.String senha, global::System.Int32 pessoaId)
        {
            EUsuario eUsuario = new EUsuario();
            eUsuario.Id = id;
            eUsuario.Login = login;
            eUsuario.Status = status;
            eUsuario.Senha = senha;
            eUsuario.PessoaId = pessoaId;
            return eUsuario;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Login
        {
            get
            {
                return _Login;
            }
            set
            {
                OnLoginChanging(value);
                ReportPropertyChanging("Login");
                _Login = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Login");
                OnLoginChanged();
            }
        }
        private global::System.String _Login;
        partial void OnLoginChanging(global::System.String value);
        partial void OnLoginChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Status
        {
            get
            {
                return _Status;
            }
            set
            {
                OnStatusChanging(value);
                ReportPropertyChanging("Status");
                _Status = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Status");
                OnStatusChanged();
            }
        }
        private global::System.Boolean _Status;
        partial void OnStatusChanging(global::System.Boolean value);
        partial void OnStatusChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Senha
        {
            get
            {
                return _Senha;
            }
            set
            {
                OnSenhaChanging(value);
                ReportPropertyChanging("Senha");
                _Senha = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Senha");
                OnSenhaChanged();
            }
        }
        private global::System.String _Senha;
        partial void OnSenhaChanging(global::System.String value);
        partial void OnSenhaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 PessoaId
        {
            get
            {
                return _PessoaId;
            }
            set
            {
                OnPessoaIdChanging(value);
                ReportPropertyChanging("PessoaId");
                _PessoaId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("PessoaId");
                OnPessoaIdChanged();
            }
        }
        private global::System.Int32 _PessoaId;
        partial void OnPessoaIdChanging(global::System.Int32 value);
        partial void OnPessoaIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("EcommerceModel", "FK_PessoaUsuario", "Pessoa")]
        public EPessoa Pessoa
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EPessoa>("EcommerceModel.FK_PessoaUsuario", "Pessoa").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EPessoa>("EcommerceModel.FK_PessoaUsuario", "Pessoa").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<EPessoa> PessoaReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<EPessoa>("EcommerceModel.FK_PessoaUsuario", "Pessoa");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<EPessoa>("EcommerceModel.FK_PessoaUsuario", "Pessoa", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}