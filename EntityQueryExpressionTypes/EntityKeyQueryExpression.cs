﻿using Newtonsoft.Json;

namespace Microsoft.Cds.Metadata.Query
{
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class EntityKeyQueryExpression
  {
    public MetadataFilterExpression Criteria { get; set; }
    public MetadataPropertiesExpression Properties { get; set; }
  }
}
