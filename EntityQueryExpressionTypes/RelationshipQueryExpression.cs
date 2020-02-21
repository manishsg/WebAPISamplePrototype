﻿using Newtonsoft.Json;

namespace Microsoft.Cds.Metadata.Query
{
  [JsonObject(ItemNullValueHandling = NullValueHandling.Ignore)]
  public class RelationshipQueryExpression
  {
    public MetadataFilterExpression Criteria { get; set; }
    public MetadataPropertiesExpression Properties { get; set; }
  }
}
