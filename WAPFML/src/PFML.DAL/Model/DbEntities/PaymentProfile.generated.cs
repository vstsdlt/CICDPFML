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

    /// <summary>[PaymentProfile]</summary>
    [Table("PaymentProfile", Schema="dbo")]
    public class PaymentProfile : BaseEntity
    {

        /// <summary>[AgentId]</summary>
        [Column("AgentId")]
        public int? AgentId { get; set; }

        /// <summary>[BankAccountNumber]</summary>
        [MaxLength(20)]
        [Column("BankAccountNumber")]
        public string BankAccountNumber { get; set; }

        /// <summary>[CreateDateTime]</summary>
        [Required]
        [Column("CreateDateTime")]
        public DateTime CreateDateTime { get; set; }

        /// <summary>[CreateUserId]</summary>
        [Required]
        [MaxLength(50)]
        [Column("CreateUserId")]
        public string CreateUserId { get; set; }

        /// <summary>[EmployerId]</summary>
        [Column("EmployerId")]
        public int? EmployerId { get; set; }

        /// <summary>[PaymentAccountTypeCode]</summary>
        [MaxLength(20)]
        [Column("PaymentAccountTypeCode")]
        public string PaymentAccountTypeCode { get; set; }

        /// <summary>[PaymentProfileId]</summary>
        [Key]
        [Required]
        [Column("PaymentProfileId", Order=1)]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PaymentProfileId { get; set; }

        /// <summary>[PaymentTypeCode]</summary>
        [Required]
        [MaxLength(20)]
        [Column("PaymentTypeCode")]
        public string PaymentTypeCode { get; set; }

        /// <summary>[RoutingTransitNumber]</summary>
        [Required]
        [MaxLength(20)]
        [Column("RoutingTransitNumber")]
        public string RoutingTransitNumber { get; set; }

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

        public virtual Employer Employer { get; set; }

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
            builder.Entity<PaymentProfile>().Property(x => x.BankAccountNumber).IsUnicode(false);
            builder.Entity<PaymentProfile>().Property(x => x.CreateUserId).IsUnicode(false);
            builder.Entity<PaymentProfile>().Property(x => x.PaymentAccountTypeCode).IsUnicode(false);
            builder.Entity<PaymentProfile>().Property(x => x.PaymentTypeCode).IsUnicode(false);
            builder.Entity<PaymentProfile>().Property(x => x.RoutingTransitNumber).IsUnicode(false);
            builder.Entity<PaymentProfile>().Property(x => x.UpdateProcess).IsUnicode(false);
            builder.Entity<PaymentProfile>().Property(x => x.UpdateUserId).IsUnicode(false);
            builder.Entity<PaymentProfile>().HasOptional(x => x.Employer).WithMany(x => x.PaymentProfiles).HasForeignKey(x => x.EmployerId);
        }

        /// <summary>Convert from PaymentProfile entity to DTO</summary>
        /// <param name="dbContext">DB Context to use for setting DTO state</param>
        /// <param name="dto">DTO to use if already created instead of creating new one (can be inherited class instead as opposed to base class)</param>
        /// <param name="entityDtos">Used internally to track which entities have been converted to DTO's already (to avoid re-converting when circularly referenced)</param>
        /// <returns>Resultant PaymentProfile DTO</returns>
        public PaymentProfileDto ToDtoDeep(FACTS.Framework.DAL.DbContext dbContext, PaymentProfileDto dto = null, Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = null)
        {
            entityDtos = entityDtos ?? new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            if (entityDtos.ContainsKey(this))
            {
                return (PaymentProfileDto)entityDtos[this];
            }

            dto = ToDto(dto);
            entityDtos.Add(this, dto);

            System.Data.Entity.Infrastructure.DbEntityEntry<PaymentProfile> entry = dbContext?.Entry(this);
            dto.IsNew = (entry?.State == EntityState.Added);
            dto.IsDeleted = (entry?.State == EntityState.Deleted);

            if (entry?.Reference(x => x.Employer)?.IsLoaded == true)
            {
                dto.Employer = Employer?.ToDtoDeep(dbContext, entityDtos: entityDtos);
            }

            return dto;
        }

        /// <summary>Convert from PaymentProfile entity to DTO w/o checking entity state or entity navigation</summary>
        /// <param name="dto">DTO to use if already created instead of creating new one (can be inherited class instead as opposed to base class)</param>
        /// <returns>Resultant PaymentProfile DTO</returns>
        public PaymentProfileDto ToDto(PaymentProfileDto dto = null)
        {

            dto = dto ?? new PaymentProfileDto();
            dto.IsNew = false;

            dto.AgentId = AgentId;
            dto.BankAccountNumber = BankAccountNumber;
            dto.CreateDateTime = CreateDateTime;
            dto.CreateUserId = CreateUserId;
            dto.EmployerId = EmployerId;
            dto.PaymentAccountTypeCode = PaymentAccountTypeCode;
            dto.PaymentProfileId = PaymentProfileId;
            dto.PaymentTypeCode = PaymentTypeCode;
            dto.RoutingTransitNumber = RoutingTransitNumber;
            dto.UpdateDateTime = UpdateDateTime;
            dto.UpdateNumber = UpdateNumber;
            dto.UpdateProcess = UpdateProcess;
            dto.UpdateUserId = UpdateUserId;

            return dto;
        }

        /// <summary>Convert from PaymentProfile DTO to entity</summary>
        /// <param name="dbContext">DB Context to use for attaching entity</param>
        /// <param name="dto">DTO to convert from</param>
        /// <param name="dtoEntities">Used internally to track which dtos have been converted to entites already (to avoid re-converting when circularly referenced)</param>
        /// <returns>Resultant PaymentProfile entity</returns>
        public static PaymentProfile FromDto(FACTS.Framework.DAL.DbContext dbContext, PaymentProfileDto dto, Dictionary<FACTS.Framework.Dto.BaseDto, BaseEntity> dtoEntities = null)
        {
            dtoEntities = dtoEntities ?? new Dictionary<FACTS.Framework.Dto.BaseDto, BaseEntity>();
            if (dtoEntities.ContainsKey(dto))
            {
                return (PaymentProfile)dtoEntities[dto];
            }

            PaymentProfile entity = new PaymentProfile();
            dtoEntities.Add(dto, entity);

            entity.AgentId = dto.AgentId;
            entity.BankAccountNumber = dto.BankAccountNumber;
            entity.CreateDateTime = dto.CreateDateTime;
            entity.CreateUserId = dto.CreateUserId;
            entity.EmployerId = dto.EmployerId;
            entity.PaymentAccountTypeCode = dto.PaymentAccountTypeCode;
            entity.PaymentProfileId = dto.PaymentProfileId;
            entity.PaymentTypeCode = dto.PaymentTypeCode;
            entity.RoutingTransitNumber = dto.RoutingTransitNumber;
            entity.UpdateDateTime = dto.UpdateDateTime;
            entity.UpdateNumber = dto.UpdateNumber;
            entity.UpdateProcess = dto.UpdateProcess;
            entity.UpdateUserId = dto.UpdateUserId;

            entity.Employer = (dto.Employer == null) ? null : Employer.FromDto(dbContext, dto.Employer, dtoEntities);

            if (dbContext != null)
            {
                dbContext.Entry(entity).State = (dto.IsNew ? EntityState.Added : (dto.IsDeleted ? EntityState.Deleted : EntityState.Modified));
            }

            return entity;
        }

    }

    /// <summary>Extension methods related to PaymentProfile entity</summary>
    public static class PaymentProfileExtension
    {

        /// <summary>Convert IEnumerable PaymentProfile to list of DTOs</summary>
        /// <param name="entities">IEnumerable PaymentProfiles</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO PaymentProfiles</returns>
        public static List<PaymentProfileDto> ToDtoListDeep(this IEnumerable<PaymentProfile> entities, FACTS.Framework.DAL.DbContext dbContext)
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<PaymentProfileDto> dtos = new List<PaymentProfileDto>();
            foreach (PaymentProfile entity in entities)
            {
                dtos.Add(entity.ToDtoDeep(dbContext, entityDtos: entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert L2E PaymentProfile to list of DTOs</summary>
        /// <param name="entities">L2E PaymentProfiles</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO PaymentProfiles</returns>
        public static List<PaymentProfileDto> ToDtoListDeep(this IQueryable<PaymentProfile> entities, FACTS.Framework.DAL.DbContext dbContext)
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<PaymentProfileDto> dtos = new List<PaymentProfileDto>();
            foreach (PaymentProfile entity in entities)
            {
                dtos.Add(entity.ToDtoDeep(dbContext, entityDtos: entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert L2E PaymentProfile to list of customized DTOs</summary>
        /// <typeparam name="T">Custom DTO derived from PaymentProfileDto</typeparam>
        /// <param name="entities">L2E PaymentProfiles</param>
        /// <param name="dbContext">DB Context to use for setting state of DTO</param>
        /// <returns>List of DTO customized PaymentProfiles</returns>
        public static List<T> ToDtoListDeep<T>(this IQueryable<PaymentProfile> entities, FACTS.Framework.DAL.DbContext dbContext) where T : PaymentProfileDto, new()
        {
            Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto> entityDtos = new Dictionary<BaseEntity, FACTS.Framework.Dto.BaseDto>();
            List<T> dtos = new List<T>();
            foreach (PaymentProfile entity in entities)
            {
                dtos.Add((T)entity.ToDtoDeep(dbContext, new T(), entityDtos));
            }
            return dtos;
        }

        /// <summary>Convert IEnumerable PaymentProfile to list of DTOs w/o checking entity state or entity navigation</summary>
        /// <param name="entities">IEnumerable PaymentProfiles</param>
        /// <returns>List of DTO PaymentProfiles</returns>
        public static List<PaymentProfileDto> ToDtoList(this IEnumerable<PaymentProfile> entities)
        {
            List<PaymentProfileDto> dtos = new List<PaymentProfileDto>();
            foreach (PaymentProfile entity in entities)
            {
                dtos.Add(entity.ToDto());
            }
            return dtos;
        }

        /// <summary>Convert L2E PaymentProfile to list of DTOs w/o checking entity state or entity navigation</summary>
        /// <param name="entities">L2E PaymentProfiles</param>
        /// <returns>List of DTO PaymentProfiles</returns>
        public static List<PaymentProfileDto> ToDtoList(this IQueryable<PaymentProfile> entities)
        {
            List<PaymentProfileDto> dtos = new List<PaymentProfileDto>();
            foreach (PaymentProfile entity in entities)
            {
                dtos.Add(entity.ToDto());
            }
            return dtos;
        }

        /// <summary>Convert L2E PaymentProfile to list of customized DTOs w/o checking entity state or entity navigation</summary>
        /// <typeparam name="T">Custom DTO derived from PaymentProfileDto</typeparam>
        /// <param name="entities">L2E PaymentProfiles</param>
        /// <returns>List of DTO customized PaymentProfiles</returns>
        public static List<T> ToDtoList<T>(this IQueryable<PaymentProfile> entities) where T : PaymentProfileDto, new()
        {
            List<T> dtos = new List<T>();
            foreach (PaymentProfile entity in entities)
            {
                dtos.Add((T)entity.ToDto(new T()));
            }
            return dtos;
        }

    }

}
