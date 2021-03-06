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

[assembly: EdmRelationshipAttribute("MarcasModel", "IDPAIS_1", "TB_PAIS", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(MarcasWeb2.Models.Pais), "TB_CLIENTES", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(MarcasWeb2.Models.Cliente), true)]

#endregion

namespace MarcasWeb2.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class MarcasEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new MarcasEntities object using the connection string found in the 'MarcasEntities' section of the application configuration file.
        /// </summary>
        public MarcasEntities() : base("name=MarcasEntities", "MarcasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MarcasEntities object.
        /// </summary>
        public MarcasEntities(string connectionString) : base(connectionString, "MarcasEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new MarcasEntities object.
        /// </summary>
        public MarcasEntities(EntityConnection connection) : base(connection, "MarcasEntities")
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
        public ObjectSet<Cliente> TB_CLIENTES
        {
            get
            {
                if ((_TB_CLIENTES == null))
                {
                    _TB_CLIENTES = base.CreateObjectSet<Cliente>("TB_CLIENTES");
                }
                return _TB_CLIENTES;
            }
        }
        private ObjectSet<Cliente> _TB_CLIENTES;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Pais> TB_PAIS
        {
            get
            {
                if ((_TB_PAIS == null))
                {
                    _TB_PAIS = base.CreateObjectSet<Pais>("TB_PAIS");
                }
                return _TB_PAIS;
            }
        }
        private ObjectSet<Pais> _TB_PAIS;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TB_CLIENTES EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTB_CLIENTES(Cliente cliente)
        {
            base.AddObject("TB_CLIENTES", cliente);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the TB_PAIS EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToTB_PAIS(Pais pais)
        {
            base.AddObject("TB_PAIS", pais);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MarcasModel", Name="Cliente")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Cliente : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Cliente object.
        /// </summary>
        /// <param name="idCliente">Initial value of the IdCliente property.</param>
        /// <param name="nombre">Initial value of the Nombre property.</param>
        /// <param name="tratamiento">Initial value of the Tratamiento property.</param>
        /// <param name="esIngles">Initial value of the EsIngles property.</param>
        /// <param name="esCarta">Initial value of the EsCarta property.</param>
        /// <param name="esEmail">Initial value of the EsEmail property.</param>
        /// <param name="esFaxi">Initial value of the EsFaxi property.</param>
        /// <param name="activo">Initial value of the Activo property.</param>
        /// <param name="esAgente">Initial value of the EsAgente property.</param>
        public static Cliente CreateCliente(global::System.Int32 idCliente, global::System.String nombre, global::System.String tratamiento, global::System.Boolean esIngles, global::System.Boolean esCarta, global::System.Boolean esEmail, global::System.Boolean esFaxi, global::System.Int32 activo, global::System.Boolean esAgente)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = idCliente;
            cliente.Nombre = nombre;
            cliente.Tratamiento = tratamiento;
            cliente.EsIngles = esIngles;
            cliente.EsCarta = esCarta;
            cliente.EsEmail = esEmail;
            cliente.EsFaxi = esFaxi;
            cliente.Activo = activo;
            cliente.EsAgente = esAgente;
            return cliente;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 IdCliente
        {
            get
            {
                return _IdCliente;
            }
            set
            {
                if (_IdCliente != value)
                {
                    OnIdClienteChanging(value);
                    ReportPropertyChanging("IdCliente");
                    _IdCliente = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("IdCliente");
                    OnIdClienteChanged();
                }
            }
        }
        private global::System.Int32 _IdCliente;
        partial void OnIdClienteChanging(global::System.Int32 value);
        partial void OnIdClienteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Rut
        {
            get
            {
                return _Rut;
            }
            set
            {
                OnRutChanging(value);
                ReportPropertyChanging("Rut");
                _Rut = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Rut");
                OnRutChanged();
            }
        }
        private global::System.String _Rut;
        partial void OnRutChanging(global::System.String value);
        partial void OnRutChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Tratamiento
        {
            get
            {
                return _Tratamiento;
            }
            set
            {
                OnTratamientoChanging(value);
                ReportPropertyChanging("Tratamiento");
                _Tratamiento = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Tratamiento");
                OnTratamientoChanged();
            }
        }
        private global::System.String _Tratamiento;
        partial void OnTratamientoChanging(global::System.String value);
        partial void OnTratamientoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                OnDireccionChanging(value);
                ReportPropertyChanging("Direccion");
                _Direccion = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Direccion");
                OnDireccionChanged();
            }
        }
        private global::System.String _Direccion;
        partial void OnDireccionChanging(global::System.String value);
        partial void OnDireccionChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Comuna
        {
            get
            {
                return _Comuna;
            }
            set
            {
                OnComunaChanging(value);
                ReportPropertyChanging("Comuna");
                _Comuna = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Comuna");
                OnComunaChanged();
            }
        }
        private global::System.String _Comuna;
        partial void OnComunaChanging(global::System.String value);
        partial void OnComunaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Ciudad
        {
            get
            {
                return _Ciudad;
            }
            set
            {
                OnCiudadChanging(value);
                ReportPropertyChanging("Ciudad");
                _Ciudad = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Ciudad");
                OnCiudadChanged();
            }
        }
        private global::System.String _Ciudad;
        partial void OnCiudadChanging(global::System.String value);
        partial void OnCiudadChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CodigoPostal
        {
            get
            {
                return _CodigoPostal;
            }
            set
            {
                OnCodigoPostalChanging(value);
                ReportPropertyChanging("CodigoPostal");
                _CodigoPostal = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CodigoPostal");
                OnCodigoPostalChanged();
            }
        }
        private global::System.String _CodigoPostal;
        partial void OnCodigoPostalChanging(global::System.String value);
        partial void OnCodigoPostalChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Email
        {
            get
            {
                return _Email;
            }
            set
            {
                OnEmailChanging(value);
                ReportPropertyChanging("Email");
                _Email = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Email");
                OnEmailChanged();
            }
        }
        private global::System.String _Email;
        partial void OnEmailChanging(global::System.String value);
        partial void OnEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                OnTelefonoChanging(value);
                ReportPropertyChanging("Telefono");
                _Telefono = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Telefono");
                OnTelefonoChanged();
            }
        }
        private global::System.String _Telefono;
        partial void OnTelefonoChanging(global::System.String value);
        partial void OnTelefonoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                OnFaxChanging(value);
                ReportPropertyChanging("Fax");
                _Fax = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Fax");
                OnFaxChanged();
            }
        }
        private global::System.String _Fax;
        partial void OnFaxChanging(global::System.String value);
        partial void OnFaxChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String SitioWeb
        {
            get
            {
                return _SitioWeb;
            }
            set
            {
                OnSitioWebChanging(value);
                ReportPropertyChanging("SitioWeb");
                _SitioWeb = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("SitioWeb");
                OnSitioWebChanged();
            }
        }
        private global::System.String _SitioWeb;
        partial void OnSitioWebChanging(global::System.String value);
        partial void OnSitioWebChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Dirigido
        {
            get
            {
                return _Dirigido;
            }
            set
            {
                OnDirigidoChanging(value);
                ReportPropertyChanging("Dirigido");
                _Dirigido = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Dirigido");
                OnDirigidoChanged();
            }
        }
        private global::System.String _Dirigido;
        partial void OnDirigidoChanging(global::System.String value);
        partial void OnDirigidoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean EsIngles
        {
            get
            {
                return _EsIngles;
            }
            set
            {
                OnEsInglesChanging(value);
                ReportPropertyChanging("EsIngles");
                _EsIngles = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EsIngles");
                OnEsInglesChanged();
            }
        }
        private global::System.Boolean _EsIngles;
        partial void OnEsInglesChanging(global::System.Boolean value);
        partial void OnEsInglesChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean EsCarta
        {
            get
            {
                return _EsCarta;
            }
            set
            {
                OnEsCartaChanging(value);
                ReportPropertyChanging("EsCarta");
                _EsCarta = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EsCarta");
                OnEsCartaChanged();
            }
        }
        private global::System.Boolean _EsCarta;
        partial void OnEsCartaChanging(global::System.Boolean value);
        partial void OnEsCartaChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean EsEmail
        {
            get
            {
                return _EsEmail;
            }
            set
            {
                OnEsEmailChanging(value);
                ReportPropertyChanging("EsEmail");
                _EsEmail = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EsEmail");
                OnEsEmailChanged();
            }
        }
        private global::System.Boolean _EsEmail;
        partial void OnEsEmailChanging(global::System.Boolean value);
        partial void OnEsEmailChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean EsFaxi
        {
            get
            {
                return _EsFaxi;
            }
            set
            {
                OnEsFaxiChanging(value);
                ReportPropertyChanging("EsFaxi");
                _EsFaxi = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EsFaxi");
                OnEsFaxiChanged();
            }
        }
        private global::System.Boolean _EsFaxi;
        partial void OnEsFaxiChanging(global::System.Boolean value);
        partial void OnEsFaxiChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Activo
        {
            get
            {
                return _Activo;
            }
            set
            {
                OnActivoChanging(value);
                ReportPropertyChanging("Activo");
                _Activo = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Activo");
                OnActivoChanged();
            }
        }
        private global::System.Int32 _Activo;
        partial void OnActivoChanging(global::System.Int32 value);
        partial void OnActivoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String IdPais
        {
            get
            {
                return _IdPais;
            }
            set
            {
                OnIdPaisChanging(value);
                ReportPropertyChanging("IdPais");
                _IdPais = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("IdPais");
                OnIdPaisChanged();
            }
        }
        private global::System.String _IdPais;
        partial void OnIdPaisChanging(global::System.String value);
        partial void OnIdPaisChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> IdAbogado
        {
            get
            {
                return _IdAbogado;
            }
            set
            {
                OnIdAbogadoChanging(value);
                ReportPropertyChanging("IdAbogado");
                _IdAbogado = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("IdAbogado");
                OnIdAbogadoChanged();
            }
        }
        private Nullable<global::System.Int32> _IdAbogado;
        partial void OnIdAbogadoChanging(Nullable<global::System.Int32> value);
        partial void OnIdAbogadoChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean EsAgente
        {
            get
            {
                return _EsAgente;
            }
            set
            {
                OnEsAgenteChanging(value);
                ReportPropertyChanging("EsAgente");
                _EsAgente = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("EsAgente");
                OnEsAgenteChanged();
            }
        }
        private global::System.Boolean _EsAgente;
        partial void OnEsAgenteChanging(global::System.Boolean value);
        partial void OnEsAgenteChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ClienteFamilia
        {
            get
            {
                return _ClienteFamilia;
            }
            set
            {
                OnClienteFamiliaChanging(value);
                ReportPropertyChanging("ClienteFamilia");
                _ClienteFamilia = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ClienteFamilia");
                OnClienteFamiliaChanged();
            }
        }
        private global::System.String _ClienteFamilia;
        partial void OnClienteFamiliaChanging(global::System.String value);
        partial void OnClienteFamiliaChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MarcasModel", "IDPAIS_1", "TB_PAIS")]
        public Pais TB_PAIS
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pais>("MarcasModel.IDPAIS_1", "TB_PAIS").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pais>("MarcasModel.IDPAIS_1", "TB_PAIS").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Pais> TB_PAISReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Pais>("MarcasModel.IDPAIS_1", "TB_PAIS");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Pais>("MarcasModel.IDPAIS_1", "TB_PAIS", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="MarcasModel", Name="Pais")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Pais : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Pais object.
        /// </summary>
        /// <param name="idPais">Initial value of the IdPais property.</param>
        /// <param name="nombre">Initial value of the Nombre property.</param>
        public static Pais CreatePais(global::System.String idPais, global::System.String nombre)
        {
            Pais pais = new Pais();
            pais.IdPais = idPais;
            pais.Nombre = nombre;
            return pais;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String IdPais
        {
            get
            {
                return _IdPais;
            }
            set
            {
                if (_IdPais != value)
                {
                    OnIdPaisChanging(value);
                    ReportPropertyChanging("IdPais");
                    _IdPais = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("IdPais");
                    OnIdPaisChanged();
                }
            }
        }
        private global::System.String _IdPais;
        partial void OnIdPaisChanging(global::System.String value);
        partial void OnIdPaisChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                OnNombreChanging(value);
                ReportPropertyChanging("Nombre");
                _Nombre = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Nombre");
                OnNombreChanged();
            }
        }
        private global::System.String _Nombre;
        partial void OnNombreChanging(global::System.String value);
        partial void OnNombreChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String NombreEspañol
        {
            get
            {
                return _NombreEspañol;
            }
            set
            {
                OnNombreEspañolChanging(value);
                ReportPropertyChanging("NombreEspañol");
                _NombreEspañol = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("NombreEspañol");
                OnNombreEspañolChanged();
            }
        }
        private global::System.String _NombreEspañol;
        partial void OnNombreEspañolChanging(global::System.String value);
        partial void OnNombreEspañolChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Iso3
        {
            get
            {
                return _Iso3;
            }
            set
            {
                OnIso3Changing(value);
                ReportPropertyChanging("Iso3");
                _Iso3 = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Iso3");
                OnIso3Changed();
            }
        }
        private global::System.String _Iso3;
        partial void OnIso3Changing(global::System.String value);
        partial void OnIso3Changed();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String CodigoAnterior
        {
            get
            {
                return _CodigoAnterior;
            }
            set
            {
                OnCodigoAnteriorChanging(value);
                ReportPropertyChanging("CodigoAnterior");
                _CodigoAnterior = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("CodigoAnterior");
                OnCodigoAnteriorChanged();
            }
        }
        private global::System.String _CodigoAnterior;
        partial void OnCodigoAnteriorChanging(global::System.String value);
        partial void OnCodigoAnteriorChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> NumericoIso
        {
            get
            {
                return _NumericoIso;
            }
            set
            {
                OnNumericoIsoChanging(value);
                ReportPropertyChanging("NumericoIso");
                _NumericoIso = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("NumericoIso");
                OnNumericoIsoChanged();
            }
        }
        private Nullable<global::System.Int32> _NumericoIso;
        partial void OnNumericoIsoChanging(Nullable<global::System.Int32> value);
        partial void OnNumericoIsoChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("MarcasModel", "IDPAIS_1", "TB_CLIENTES")]
        public EntityCollection<Cliente> TB_CLIENTES
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Cliente>("MarcasModel.IDPAIS_1", "TB_CLIENTES");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Cliente>("MarcasModel.IDPAIS_1", "TB_CLIENTES", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
