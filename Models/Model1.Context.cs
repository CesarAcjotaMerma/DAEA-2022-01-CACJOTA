﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab15.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SchoolEntities : DbContext
    {
        public SchoolEntities()
            : base("name=SchoolEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<CourseGrade> CourseGrade { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public virtual DbSet<OnlineCourse> OnlineCourse { get; set; }
        public virtual DbSet<OnsiteCourse> OnsiteCourse { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tbl_usuario> tbl_usuario { get; set; }
    
        public virtual ObjectResult<BuscarPersonaNombre_Result> BuscarPersonaNombre(string firstName)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<BuscarPersonaNombre_Result>("BuscarPersonaNombre", firstNameParameter);
        }
    
        public virtual int DeleteOfficeAssignment(Nullable<int> instructorID)
        {
            var instructorIDParameter = instructorID.HasValue ?
                new ObjectParameter("InstructorID", instructorID) :
                new ObjectParameter("InstructorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteOfficeAssignment", instructorIDParameter);
        }
    
        public virtual int DeletePerson(Nullable<int> personID)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("PersonID", personID) :
                new ObjectParameter("PersonID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeletePerson", personIDParameter);
        }
    
        public virtual ObjectResult<GetStudentGrades_Result> GetStudentGrades(Nullable<int> studentID)
        {
            var studentIDParameter = studentID.HasValue ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentGrades_Result>("GetStudentGrades", studentIDParameter);
        }
    
        public virtual ObjectResult<InicioSesionUsuario_Result> InicioSesionUsuario(string usuario_nombre, string usuario_password)
        {
            var usuario_nombreParameter = usuario_nombre != null ?
                new ObjectParameter("usuario_nombre", usuario_nombre) :
                new ObjectParameter("usuario_nombre", typeof(string));
    
            var usuario_passwordParameter = usuario_password != null ?
                new ObjectParameter("usuario_password", usuario_password) :
                new ObjectParameter("usuario_password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<InicioSesionUsuario_Result>("InicioSesionUsuario", usuario_nombreParameter, usuario_passwordParameter);
        }
    
        public virtual ObjectResult<byte[]> InsertOfficeAssignment(Nullable<int> instructorID, string location)
        {
            var instructorIDParameter = instructorID.HasValue ?
                new ObjectParameter("InstructorID", instructorID) :
                new ObjectParameter("InstructorID", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("InsertOfficeAssignment", instructorIDParameter, locationParameter);
        }
    
        public virtual ObjectResult<Nullable<decimal>> InsertPerson(string lastName, string firstName, Nullable<System.DateTime> hireDate, Nullable<System.DateTime> enrollmentDate)
        {
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var enrollmentDateParameter = enrollmentDate.HasValue ?
                new ObjectParameter("EnrollmentDate", enrollmentDate) :
                new ObjectParameter("EnrollmentDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<decimal>>("InsertPerson", lastNameParameter, firstNameParameter, hireDateParameter, enrollmentDateParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<byte[]> UpdateOfficeAssignment(Nullable<int> instructorID, string location, byte[] origTimestamp)
        {
            var instructorIDParameter = instructorID.HasValue ?
                new ObjectParameter("InstructorID", instructorID) :
                new ObjectParameter("InstructorID", typeof(int));
    
            var locationParameter = location != null ?
                new ObjectParameter("Location", location) :
                new ObjectParameter("Location", typeof(string));
    
            var origTimestampParameter = origTimestamp != null ?
                new ObjectParameter("OrigTimestamp", origTimestamp) :
                new ObjectParameter("OrigTimestamp", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("UpdateOfficeAssignment", instructorIDParameter, locationParameter, origTimestampParameter);
        }
    
        public virtual int UpdatePerson(Nullable<int> personID, string lastName, string firstName, Nullable<System.DateTime> hireDate, Nullable<System.DateTime> enrollmentDate)
        {
            var personIDParameter = personID.HasValue ?
                new ObjectParameter("PersonID", personID) :
                new ObjectParameter("PersonID", typeof(int));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var hireDateParameter = hireDate.HasValue ?
                new ObjectParameter("HireDate", hireDate) :
                new ObjectParameter("HireDate", typeof(System.DateTime));
    
            var enrollmentDateParameter = enrollmentDate.HasValue ?
                new ObjectParameter("EnrollmentDate", enrollmentDate) :
                new ObjectParameter("EnrollmentDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdatePerson", personIDParameter, lastNameParameter, firstNameParameter, hireDateParameter, enrollmentDateParameter);
        }
    }
}
