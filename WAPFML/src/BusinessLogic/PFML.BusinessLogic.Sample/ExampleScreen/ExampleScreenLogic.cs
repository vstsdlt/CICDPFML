using System;
using System.Collections.Generic;
using System.Linq;
using FACTS.Framework.DAL;
using FACTS.Framework.Service;
using PFML.DAL.Model.DbEntities;
using PFML.Shared.Model.DbDtos;
using DbContext = PFML.DAL.Model.DbContext;

namespace PFML.BusinessLogic.Sample.ExampleScreen
{

    public static class ExampleScreenLogic
    {

        [OperationMethod]
        public static List<SecurityPermissionDto> Search(string sourceType, string sourceName, string targetType, string targetName, string accessType)
        {
            using (DbContext dbContext = new DbContext())
            {
                var query = dbContext.SecurityPermissions
                                     .ConditionalWhere(sourceType, x => x.SourceType == sourceType)
                                     .ConditionalWhere(sourceName, x => x.SourceName == sourceName)
                                     .ConditionalWhere(targetType, x => x.TargetType == targetType)
                                     .ConditionalWhere(targetName, x => x.TargetName == targetName)
                                     .ConditionalWhere(accessType, x => x.AccessType == accessType);
                return query.ToDtoList();
            }
        }

        [OperationMethod]
        public static void Save(SecurityPermissionDto securityPermissionDto)
        {
            using (DbContext dbContext = new DbContext())
            {
                SecurityPermission.FromDto(dbContext, securityPermissionDto);
                dbContext.SaveChanges();
            }
        }

    }

}
