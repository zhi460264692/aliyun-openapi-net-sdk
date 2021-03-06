/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20180510;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20180510
{
    public class UpdateFCTriggerRequest : RpcAcsRequest<UpdateFCTriggerResponse>
    {
        public UpdateFCTriggerRequest()
            : base("Cdn", "2018-05-10", "UpdateFCTrigger")
        {
        }

		private string notes;

		private string action;

		private string triggerARN;

		private string sourceARN;

		private long? ownerId;

		private string roleARN;

		public string Notes
		{
			get
			{
				return notes;
			}
			set	
			{
				notes = value;
				DictionaryUtil.Add(BodyParameters, "Notes", value);
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public string TriggerARN
		{
			get
			{
				return triggerARN;
			}
			set	
			{
				triggerARN = value;
				DictionaryUtil.Add(QueryParameters, "TriggerARN", value);
			}
		}

		public string SourceARN
		{
			get
			{
				return sourceARN;
			}
			set	
			{
				sourceARN = value;
				DictionaryUtil.Add(BodyParameters, "SourceARN", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string RoleARN
		{
			get
			{
				return roleARN;
			}
			set	
			{
				roleARN = value;
				DictionaryUtil.Add(BodyParameters, "RoleARN", value);
			}
		}

        public override UpdateFCTriggerResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateFCTriggerResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}