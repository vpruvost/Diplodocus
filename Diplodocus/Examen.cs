//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diplodocus
{
    using System;
    using System.Collections.Generic;
    
    public partial class Examen
    {
        public int idExamen { get; set; }
        public string nameExamen { get; set; }
        public string typeExamen { get; set; }
        public string markExamen { get; set; }
        public int SchoolSubjectMarkIdMark { get; set; }
    
        public virtual SchoolSubjectMark aSchoolSubjectMark { get; set; }
    }
}