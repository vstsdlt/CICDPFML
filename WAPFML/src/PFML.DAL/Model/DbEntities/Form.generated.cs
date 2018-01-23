// ----------------------------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a compiler emitter: FACTS.Framework.Analysis.Generators.DAL.EntityEmitter
//
// Changes to this file may cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
// ----------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using PFML.Shared.Model.DbDtos;
using FACTS.Framework.DAL;

namespace PFML.DAL.Model.DbEntities
{

    /// <summary>[Form]</summary>
    [Table("Form", Schema="dbo")]
    public class Form : BaseEntity
    {

        /// <summary>[CreateDateTime]</summary>
        [Required]
        [Column("CreateDateTime")]
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        [Required]
        [MaxLength(50)]
        [Column("CreateUserId")]
        public string CreateUserId { get; set; }

        /// <summary>[FormId]</summary>
        [Key]
        [Required]
        [Column("FormId", Order=1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FormId { get; set; }

        /// <summary>[FormTypeCode]</summary>
        [Required]
        [MaxLength(20)]
        [Column("FormTypeCode")]
        public string FormTypeCode { get; set; }

        /// <summary>[StatusCode]</summary>
        [Required]
        [MaxLength(20)]
        [Column("StatusCode")]
        public string StatusCode { get; set; }

        /// <summary>[UpdateDateTime]</summary>
        [Required]
        [Column("UpdateDateTime")]
        [ConcurrencyCheck]
        public DateTime UpdateDateTime { get; set; }

        /// <summary>[UpdateNumber]</summary>
        [Column("UpdateNumber")]
        public int? UpdateNumber { get; set; }

        /// <summary>[UpdateProcess]</summary>
        [MaxLength(100)]
        [Column("UpdateProcess")]
        public string UpdateProcess { get; set; }

        /// <summary>[UpdateUserId]</summary>
        [Required]
        [MaxLength(50)]
        [Column("UpdateUserId")]
        public string UpdateUserId { get; set; }

        private ICollection<FormAttachment> formAttachments { get; set; }
        public virtual ICollection<FormAttachment> FormAttachments { get { return formAttachments ?? (formAttachments = new Collection<FormAttachment>()); } protected set { formAttachments = value; } }

        private ICollection<VoluntaryPlanWaiverRequest> voluntaryPlanWaiverRequests { get; set; }
        public virtual ICollection<VoluntaryPlanWaiverRequest> VoluntaryPlanWaiverRequests { get { return voluntaryPlanWaiverRequests ?? (voluntaryPlanWaiverRequests = new Collection<VoluntaryPlanWaiverRequest>()); } protected set { voluntaryPlanWaiverRequests = value; } }

        public override void SetAuditFields(EntityState state)
        {
            string username = FACTS.Framework.Service.Context.UserName ?? "UNKNOWN";
            DateTime timestamp = FACTS.Framework.Utility.DateTimeUtil.Now;

            if (state == EntityState.Added)
            {
                CreateUserId = username;
                CreateDateTime = new System.Data.SqlTypes.SqlDateTime(timestamp).Value;
                UpdateUserId = username;
                UpdateDateTime = new System.Data.SqlTypes.SqlDateTime(timestamp).Value;
                UpdateNumber = 0;
                UpdateProcess = FACTS.Framework.Utility.StringUtil.CapLength(FACTS.Framework.Service.Context.Process.ToString(), 100);
            }
            else if (state == EntityState.Modified)
            {
                UpdateUserId = username;
                UpdateDateTime = new System.Data.SqlTypes.SqlDateTime(timestamp).Value;
                UpdateNumber = (UpdateNumber ?? 0) + 1;
                UpdateProcess = FACTS.Framework.Utility.StringUtil.CapLength(FACTS.Framework.Service.Context.Process.ToString(), 100);
            }
        }

        internal static void ModelCreating(DbModelBuilder builder)
        {
            builder.Entity<Form>().Property(x => x.CreateUserId).IsUnicode(false);
            builder.Entity<Form>().Property(x => x.FormTypeCode).IsUnicode(false);
            builder.Entity<Form>().Property(x => x.StatusCode).IsUnicode(false);
            builder.Entity<Form>().Property(x => x.UpdateProcess).IsUnicode(false);
            builder.Entity<Form>().Property(x => x.UpdateUserId).IsUnicode(false);
        }

        /// <summary>Convert from Form entity to DTO</summary>
        /// <param name="dbContext">DB Context to use for setting DTO state</param>
        /// <param name="dto">DTO to use if already created instead of creating new one (can be inherited class instead as opposed to base class)</param>
        /// <param name="entityDtos">Used internally to track which entities have been converted to DTO's already (to avoid re-converting when circularly referenced)</param>
        /// <returns>Resultant Form DTO</returns>
        public FormDto ToDtoDeep(FACTS.Framework.DAL.DbContext dbContext, FormDto dto = null, Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = null)
        {
            entityDtos = entityDtos ?? new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            if (entityDtos.ContainsKey(this))
            {
                return (FormDto)entityDtos[this];
            }

            dto = ToDto(dto);
            entityDtos.Add(this, dto);

            System.Data.Entity.Infrastructure.DbEntityEntry<Form> entry = dbContext?.Entry(this);
            dto.IsNew = (entry?.State == EntityState.Added);
            dto.IsDeleted = (entry?.State == EntityState.Deleted);

            if (entry?.Collection(x => x.FormAttachments)?.IsLoaded == true)
            {
                foreach (FormAttachment formAttachment in FormAttachments)
                {
                    dto.FormAttachments.Add(formAttachment.ToDtoDeep(dbContext, entityDtos: entityDtos));
                }
            }
            if (entry?.Collection(x => x.VoluntaryPlanWaiverRequests)?.IsLoaded == true)
            {
                foreach (VoluntaryPlanWaiverRequest voluntaryPlanWaiverRequest in VoluntaryPlanWaiverRequests)
                {
                    dto.VoluntaryPlanWaiverRequests.Add(voluntaryPlanWaiverRequest.ToDtoDeep(dbContext, entityDtos: entityDtos));
                }
            }

            return dto;
        }

        /// <summary>Convert from Form entity to DTO w/o checking entity state or entity navigation</summary>
        /// <param name="dto">DTO to use if already created instead of creating new one (can be inherited class instead as opposed to base class)</param>
        /// <returns>Resultant Form DTO</returns>
        public FormDto ToDto(FormDto dto = null)
        {

            dto = dto ?? new FormDto();
            dto.IsNew = false;

            dto.CreateDateTime = CreateDateTime;
            dto.CreateUserId = CreateUserId;
            dto.FormId = FormId;
            dto.FormTypeCode = FormTypeCode;
            dto.StatusCode = StatusCode;
            dto.UpdateDateTime = UpdateDateTime;
            dto.UpdateNumber = UpdateNumber;
            dto.UpdateProcess = UpdateProcess;
            dto.UpdateUserId = UpdateUserId;

            return dto;
        }

        /// <summary>Convert from Form DTO to entity</summary>
        /// <param name="dbContext">DB Context to use for attaching entity</param>
        /// <param name="dto">DTO to convert from</param>
        /// <param name="dtoEntities">Used internally to track which dtos have been converted to entites already (to avoid re-converting when circularly referenced)</param>
        /// <returns>Resultant Form entity</returns>
        public static Form FromDto(FACTS.Framework.DAL.DbContext dbContext, FormDto dto, Dictionary<FACTS.Framework.Dto.BaseDto, BaseEntity> dtoEntities = null)
        {
            dtoEntities = dtoEntities ?? new Dictionary<FACTS.Framework.Dto.BaseDto, BaseEntity>();
            if (dtoEntities.ContainsKey(dto))
            {
                return (Form)dtoEntities[dto];
            }

            Form entity = new Form();
            dtoEntities.Add(dto, entity);

            entity.CreateDateTime = dto.CreateDateTime;
            entity.CreateUserId = dto.CreateUserId;
            entity.FormId = dto.FormId;
            entity.FormTypeCode = dto.FormTypeCode;
            entity.StatusCode = dto.StatusCode;
            entity.UpdateDateTime = dto.UpdateDateTime;
            entity.UpdateNumber = dto.UpdateNumber;
            entity.UpdateProcess = dto.UpdateProcess;
            entity.UpdateUserId = dto.UpdateUserId;

            if (dto.FormAttachments != null)
            {
                foreach (FormAttachmentDto formAttachment in dto.FormAttachments)
                {
                    entity.FormAttachments.Add(DbEntities.FormAttachment.FromDto(dbContext, formAttachment, dtoEntities));
                }
            }
            if (dto.VoluntaryPlanWaiverRequests != null)
            {
                foreach (VoluntaryPlanWaiverRequestDto voluntaryPlanWaiverRequest in dto.VoluntaryPlanWaiverRequests)
                {
                    entity.VoluntaryPlanWaiverRequests.Add(DbEntities.VoluntaryPlanWaiverRequest.FromDto(dbContext, voluntaryPlanWaiverRequest, dtoEntities));
                }
            }

            if (dbContext != null)
            {
                dbContext.Entry(entity).State = (dto.IsNew ? EntityState.Added : (dto.IsDeleted ? EntityState.Deleted : EntityState.Modified));
            }

            return entity;
        }

    }

    /// <summary>Extension methods related to Form entity</summary>
    public static class FormExtension
    {

        /// <summary>Convert IEnumerable Form to list of DTOs</summary>
        /// <param name="entities">IEnumerable Forms</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO Forms</returns>
        public static List<FormDto> ToDtoListDeep(this IEnumerable<Form> entities, FACTS.Framework.DAL.DbContext dbContext)
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<FormDto> dtos = new List<FormDto>();
            foreach (Form entity in entities)
            {
                dtos.Add(entity.ToDtoDeep(dbContext, entityDtos: entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert L2E Form to list of DTOs</summary>
        /// <param name="entities">L2E Forms</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO Forms</returns>
        public static List<FormDto> ToDtoListDeep(this IQueryable<Form> entities, FACTS.Framework.DAL.DbContext dbContext)
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<FormDto> dtos = new List<FormDto>();
            foreach (Form entity in entities)
            {
                dtos.Add(entity.ToDtoDeep(dbContext, entityDtos: entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert L2E Form to list of customized DTOs</summary>
        /// <typeparam name="T">Custom DTO derived from FormDto</typeparam>
        /// <param name="entities">L2E Forms</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO customized Forms</returns>
        public static List<T> ToDtoListDeep<T>(this IQueryable<Form> entities, FACTS.Framework.DAL.DbContext dbContext) where T : FormDto, new()
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<T> dtos = new List<T>();
            foreach (Form entity in entities)
            {
                dtos.Add((T)entity.ToDtoDeep(dbContext, new T(), entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert IEnumerable Form to list of DTOs w/o checking entity state or entity navigation</summary>
        /// <param name="entities">IEnumerable Forms</param>
        /// <returns>List of DTO Forms</returns>
        public static List<FormDto> ToDtoList(this IEnumerable<Form> entities)
        {
            List<FormDto> dtos = new List<FormDto>();
            foreach (Form entity in entities)
            {
                dtos.Add(entity.ToDto());
            }
            return dtos;
        }

        /// <summary>Convert L2E Form to list of DTOs w/o checking entity state or entity navigation</summary>
        /// <param name="entities">L2E Forms</param>
        /// <returns>List of DTO Forms</returns>
        public static List<FormDto> ToDtoList(this IQueryable<Form> entities)
        {
            List<FormDto> dtos = new List<FormDto>();
            foreach (Form entity in entities)
            {
                dtos.Add(entity.ToDto());
            }
            return dtos;
        }

        /// <summary>Convert L2E Form to list of customized DTOs w/o checking entity state or entity navigation</summary>
        /// <typeparam name="T">Custom DTO derived from FormDto</typeparam>
        /// <param name="entities">L2E Forms</param>
        /// <returns>List of DTO customized Forms</returns>
        public static List<T> ToDtoList<T>(this IQueryable<Form> entities) where T : FormDto, new()
        {
            List<T> dtos = new List<T>();
            foreach (Form entity in entities)
            {
                dtos.Add((T)entity.ToDto(new T()));
            }
            return dtos;
        }

    }

}
