//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IBD.MEDEM.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientePuntosCarga
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ClientePuntosCarga()
        {
            this.ComentariosOrigen = new HashSet<ComentariosOrigen>();
            this.Documentos = new HashSet<Documentos>();
        }
    
        public int IdPuntoCarga { get; set; }
        public int IdCliente { get; set; }
        public string Codigo { get; set; }
        public int IdDireccion { get; set; }
        public string RPU { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public Nullable<decimal> TarifaDemandaCFE { get; set; }
        public Nullable<decimal> SegundaDemandaAnualMax { get; set; }
        public Nullable<decimal> EnergiaBase { get; set; }
        public Nullable<decimal> EnergiaIntermedia { get; set; }
        public Nullable<decimal> EnergiaPunta { get; set; }
        public Nullable<decimal> DemandaFacturable { get; set; }
        public Nullable<decimal> PagoActual { get; set; }
        public bool Estatus { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
        public string UsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Direcciones Direcciones { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ComentariosOrigen> ComentariosOrigen { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documentos> Documentos { get; set; }
    }
}