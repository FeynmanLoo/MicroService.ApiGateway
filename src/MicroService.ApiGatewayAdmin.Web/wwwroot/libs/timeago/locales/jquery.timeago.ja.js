
	<CoordinatorQueryMaxThreads>16</CoordinatorQueryMaxThreads>
	<CoordinatorQueryBalancingFactor>-1</CoordinatorQueryBalancingFactor>
	<CoordinatorQueryBoostPriorityLevel>3</CoordinatorQueryBoostPriorityLevel>
	<LockManager>
		<DefaultLockTimeoutMS>-1</DefaultLockTimeoutMS>
		<LockWaitGranularityMS>5000</LockWaitGranularityMS>
		<DeadlockDetectionGranularityMS>30000</DeadlockDetectionGranularityMS>
	</LockManager>
	<ThreadPool>
		<Parsing>
			<Short>
				<NumThreads>0</NumThreads>
				<PriorityRatio>0</PriorityRatio>
				<Concurrency>2</Concurrency>
				<StackSizeKB>512</StackSizeKB>
				<GroupAffinity/>
			</Short>
			<Long>
				<NumThreads>0</NumThreads>
				<PriorityRatio>0</PriorityRatio>
				<Concurrency>2</Con