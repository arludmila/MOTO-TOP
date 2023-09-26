using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Utils
{
    public class DtoMapper
    {
        public static void MapDtoToEntity(object sourceDto, object destinationEntity)
        {
            var dtoType = sourceDto.GetType();
            var entityType = destinationEntity.GetType();

            // Get the properties of the DTO
            var dtoProperties = dtoType.GetProperties();

            foreach (var dtoProperty in dtoProperties)
            {
                // Find the corresponding property in the entity by name
                var entityProperty = entityType.GetProperty(dtoProperty.Name);

                // Check if the entity property exists and is writable
                if (entityProperty != null && entityProperty.CanWrite)
                {
                    // Get the value from the DTO property
                    var dtoValue = dtoProperty.GetValue(sourceDto);

                    // Set the value to the entity property
                    entityProperty.SetValue(destinationEntity, dtoValue);
                }
            }
            
        }
        public static T CreateEntityFromDto<T>(object sourceDto) where T : new()
        {
            var entity = new T();
            var dtoType = sourceDto.GetType();
            var entityType = typeof(T);

            // Get the properties of the DTO
            var dtoProperties = dtoType.GetProperties();

            foreach (var dtoProperty in dtoProperties)
            {
                // Find the corresponding property in the entity by name
                var entityProperty = entityType.GetProperty(dtoProperty.Name);

                // Check if the entity property exists and is writable
                if (entityProperty != null && entityProperty.CanWrite)
                {
                    // Get the value from the DTO property
                    var dtoValue = dtoProperty.GetValue(sourceDto);

                    // Set the value to the entity property
                    entityProperty.SetValue(entity, dtoValue);
                }
            }

            return entity;
        }


    }
}
