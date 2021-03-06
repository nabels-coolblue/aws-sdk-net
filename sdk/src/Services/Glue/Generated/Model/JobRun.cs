/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains information about a job run.
    /// </summary>
    public partial class JobRun
    {
        private int? _allocatedCapacity;
        private Dictionary<string, string> _arguments = new Dictionary<string, string>();
        private int? _attempt;
        private DateTime? _completedOn;
        private string _errorMessage;
        private string _id;
        private string _jobName;
        private JobRunState _jobRunState;
        private DateTime? _lastModifiedOn;
        private List<Predecessor> _predecessorRuns = new List<Predecessor>();
        private string _previousRunId;
        private DateTime? _startedOn;
        private string _triggerName;

        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// The amount of infrastructure capacity allocated to this job run.
        /// </para>
        /// </summary>
        public int AllocatedCapacity
        {
            get { return this._allocatedCapacity.GetValueOrDefault(); }
            set { this._allocatedCapacity = value; }
        }

        // Check to see if AllocatedCapacity property is set
        internal bool IsSetAllocatedCapacity()
        {
            return this._allocatedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The job arguments associated with this run.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && this._arguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number or the attempt to run this job.
        /// </para>
        /// </summary>
        public int Attempt
        {
            get { return this._attempt.GetValueOrDefault(); }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time this job run completed.
        /// </para>
        /// </summary>
        public DateTime CompletedOn
        {
            get { return this._completedOn.GetValueOrDefault(); }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message associated with this job run.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of this job run.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job being run.
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobRunState. 
        /// <para>
        /// The current state of the job run.
        /// </para>
        /// </summary>
        public JobRunState JobRunState
        {
            get { return this._jobRunState; }
            set { this._jobRunState = value; }
        }

        // Check to see if JobRunState property is set
        internal bool IsSetJobRunState()
        {
            return this._jobRunState != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The last time this job run was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedOn
        {
            get { return this._lastModifiedOn.GetValueOrDefault(); }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredecessorRuns. 
        /// <para>
        /// A list of predecessors to this job run.
        /// </para>
        /// </summary>
        public List<Predecessor> PredecessorRuns
        {
            get { return this._predecessorRuns; }
            set { this._predecessorRuns = value; }
        }

        // Check to see if PredecessorRuns property is set
        internal bool IsSetPredecessorRuns()
        {
            return this._predecessorRuns != null && this._predecessorRuns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The ID of the previous run of this job.
        /// </para>
        /// </summary>
        public string PreviousRunId
        {
            get { return this._previousRunId; }
            set { this._previousRunId = value; }
        }

        // Check to see if PreviousRunId property is set
        internal bool IsSetPreviousRunId()
        {
            return this._previousRunId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time at which this job run was started.
        /// </para>
        /// </summary>
        public DateTime StartedOn
        {
            get { return this._startedOn.GetValueOrDefault(); }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerName. 
        /// <para>
        /// The name of the trigger for this job run.
        /// </para>
        /// </summary>
        public string TriggerName
        {
            get { return this._triggerName; }
            set { this._triggerName = value; }
        }

        // Check to see if TriggerName property is set
        internal bool IsSetTriggerName()
        {
            return this._triggerName != null;
        }

    }
}