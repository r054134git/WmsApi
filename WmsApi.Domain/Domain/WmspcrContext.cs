using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WmsApi.Domain
{
	/// <summary>
	/// A <see cref="DbContext" /> instance represents a session with the database and can be used to query and save instances of entities. 
	/// </summary>
	public partial class WmspcrContext : DbContext
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="WmspcrContext"/> class.
		/// </summary>
		/// <param name="options">The options to be used by this <see cref="DbContext" />.</param>
		public WmspcrContext(DbContextOptions<WmspcrContext> options)
			: base(options)
		{
		}

		#region Generated Properties
        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.Tagcopylist"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.Tagcopylist"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.Tagcopylist> Tagcopylists { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCoilCar"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCoilCar"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqCoilCar> TEqCoilCars { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCrane"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCrane"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqCrane> TEqCranes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCraneWeight"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCraneWeight"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqCraneWeight> TEqCraneWeights { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCrossVehicle"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqCrossVehicle"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqCrossVehicle> TEqCrossVehicles { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqFenceArea"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqFenceArea"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqFenceArea> TEqFenceAreas { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqFenceDoor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqFenceDoor"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqFenceDoor> TEqFenceDoors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqGateEntry"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqGateEntry"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqGateEntry> TEqGateEntries { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqGateParking"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqGateParking"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqGateParking> TEqGateParkings { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqTrainCar"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqTrainCar"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqTrainCar> TEqTrainCars { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqTrain"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqTrain"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqTrain> TEqTrains { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqWalkingBeam"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TEqWalkingBeam"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TEqWalkingBeam> TEqWalkingBeams { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.Tmmcr01"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.Tmmcr01"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.Tmmcr01> Tmmcr01s { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlAutoCode"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlAutoCode"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlAutoCode> TPlAutoCodes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBackRepack"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBackRepack"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlBackRepack> TPlBackRepacks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBackReturn"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBackReturn"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlBackReturn> TPlBackReturns { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBay"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBay"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlBay> TPlBays { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBayTransfer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlBayTransfer"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlBayTransfer> TPlBayTransfers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlCraneMaintenance"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlCraneMaintenance> TPlCraneMaintenances { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlCraneTask"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlCraneTask"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlCraneTask> TPlCraneTasks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlCrossBayTask"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlCrossBayTask"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlCrossBayTask> TPlCrossBayTasks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlDeliveryPlan"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlDeliveryPlan> TPlDeliveryPlans { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlFinishLine"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlFinishLine"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlFinishLine> TPlFinishLines { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlMaterial"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlMaterial"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlMaterial> TPlMaterials { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlOffline"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlOffline"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlOffline> TPlOfflines { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlProductionDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlProductionDetail"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlProductionDetail> TPlProductionDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlProduction"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlProduction"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlProduction> TPlProductions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlStackTranfer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlStackTranfer"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlStackTranfer> TPlStackTranfers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTrainDelivery"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTrainDelivery"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTrainDelivery> TPlTrainDeliveries { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckBack"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckBack"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckBack> TPlTruckBacks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckDelivery"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckDelivery"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckDelivery> TPlTruckDeliveries { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckDeliveryDetail"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckDeliveryDetail> TPlTruckDeliveryDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckLoadListDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckLoadListDetail"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckLoadListDetail> TPlTruckLoadListDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckLoadList"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckLoadList"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckLoadList> TPlTruckLoadLists { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayOut"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckQueueInBayOut> TPlTruckQueueInBayOuts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckQueueInBayShift"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckQueueInBayShift> TPlTruckQueueInBayShifts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckTransfer"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TPlTruckTransfer"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TPlTruckTransfer> TPlTruckTransfers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcBay"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcBay"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcBay> TRcBays { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcCameraIds"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcCameraIds"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcCameraIds> TRcCameraIds { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcClassStock"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcClassStock"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcClassStock> TRcClassStocks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcCraneTask"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcCraneTask"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcCraneTask> TRcCraneTasks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcInventory"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcInventory"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcInventory> TRcInventories { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcInventoryDetail"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcInventoryDetail"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcInventoryDetail> TRcInventoryDetails { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcInventoryTemp"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcInventoryTemp"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcInventoryTemp> TRcInventoryTemps { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcLocationMaterial"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcLocationMaterial"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcLocationMaterial> TRcLocationMaterials { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcLocationsRate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcLocationsRate"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcLocationsRate> TRcLocationsRates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcLog"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcLog> TRcLogs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcMaterialEventMigrate"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcMaterialEventMigrate"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcMaterialEventMigrate> TRcMaterialEventMigrates { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcMaterialEvent"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcMaterialEvent"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcMaterialEvent> TRcMaterialEvents { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcMaterial"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcMaterial"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcMaterial> TRcMaterials { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTelegram"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTelegram"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcTelegram> TRcTelegrams { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTrainDelivery"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTrainDelivery"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcTrainDelivery> TRcTrainDeliveries { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTrainDeliveryPick"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTrainDeliveryPick"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcTrainDeliveryPick> TRcTrainDeliveryPicks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTrainNode"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTrainNode"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcTrainNode> TRcTrainNodes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTruckBayQueue"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcTruckBayQueue> TRcTruckBayQueues { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTruckLoadingLog"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcTruckLoadingLog> TRcTruckLoadingLogs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTruck"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcTruck"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcTruck> TRcTrucks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcWorkMode"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRcWorkMode"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRcWorkMode> TRcWorkModes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlCranePlanType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlCranePlanType"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRlCranePlanType> TRlCranePlanTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlDispatchRules"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlDispatchRules"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRlDispatchRules> TRlDispatchRules { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlLocationAssign"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlLocationAssign"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRlLocationAssign> TRlLocationAssigns { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlLocation"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlLocation"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRlLocation> TRlLocations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlRegionRange"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlRegionRange"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRlRegionRange> TRlRegionRanges { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlTransferPrewired"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TRlTransferPrewired"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TRlTransferPrewired> TRlTransferPrewireds { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScApp"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScApp"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TScApp> TScApps { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScClient"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScClient"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TScClient> TScClients { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScColor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScColor"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TScColor> TScColors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScDictionary"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScDictionary"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TScDictionary> TScDictionaries { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScTransferSpec"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScTransferSpec"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TScTransferSpec> TScTransferSpecs { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScTransferTerminal"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TScTransferTerminal"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TScTransferTerminal> TScTransferTerminals { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTestPre"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTestPre"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTestPre> TTestPres { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrConveyingChain"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrConveyingChain"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrConveyingChain> TTrConveyingChains { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrCpl"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrCpl"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrCpl> TTrCpls { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrCrane"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrCrane"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrCrane> TTrCranes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrCrossTrain"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrCrossTrain"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrCrossTrain> TTrCrossTrains { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrEntry"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrEntry"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrEntry> TTrEntries { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrFenceArea"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrFenceArea"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrFenceArea> TTrFenceAreas { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrFenceDoor"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrFenceDoor"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrFenceDoor> TTrFenceDoors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrLocationMaterialEvent"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrLocationMaterialEvent> TTrLocationMaterialEvents { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrLocationMaterial"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrLocationMaterial"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrLocationMaterial> TTrLocationMaterials { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrMessageReceived"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrMessageReceived"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrMessageReceived> TTrMessageReceiveds { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrMessageSend"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrMessageSend"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrMessageSend> TTrMessageSends { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrNetwork"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrNetwork"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrNetwork> TTrNetworks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrParkingPlace"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrParkingPlace"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrParkingPlace> TTrParkingPlaces { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTodoList"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTodoList"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrTodoList> TTrTodoLists { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTrafficLight"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTrafficLight"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrTrafficLight> TTrTrafficLights { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTrain"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTrain"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrTrain> TTrTrains { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTruckBayQueue"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTruckBayQueue"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrTruckBayQueue> TTrTruckBayQueues { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTruckQueue"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTruckQueue"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrTruckQueue> TTrTruckQueues { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTruck"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrTruck"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrTruck> TTrTrucks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrUser"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TTrUser"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TTrUser> TTrUsers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmColSet"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmColSet"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmColSet> TUmColSets { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmGroup"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmGroup"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmGroup> TUmGroups { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmMenu"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmMenu"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmMenu> TUmMenus { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmPermission"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmPermission"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmPermission> TUmPermissions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmRolePermission"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmRolePermission"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmRolePermission> TUmRolePermissions { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmRole"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmRole"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmRole> TUmRoles { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmShift"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmShift"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmShift> TUmShifts { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmUser"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TUmUser"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TUmUser> TUmUsers { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhArea"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhArea"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhArea> TWhAreas { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhBay"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhBay"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhBay> TWhBays { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhCranePassage"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhCranePassage"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhCranePassage> TWhCranePassages { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhCraneTravelSpace"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhCraneTravelSpace> TWhCraneTravelSpaces { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhDestHouse"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhDestHouse"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhDestHouse> TWhDestHouses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhError"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhError"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhError> TWhErrors { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhLocation"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhLocation"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhLocation> TWhLocations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhPlanType"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhPlanType"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhPlanType> TWhPlanTypes { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhStack"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhStack"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhStack> TWhStacks { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhTrainLocation"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhTrainLocation"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhTrainLocation> TWhTrainLocations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhTruckParkingPlace"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhTruckParkingPlace"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhTruckParkingPlace> TWhTruckParkingPlaces { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhTruckPassage"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhTruckPassage"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhTruckPassage> TWhTruckPassages { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhWarehouse"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.TWhWarehouse"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.TWhWarehouse> TWhWarehouses { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCompareNameNo"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCompareNameNo"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VCompareNameNo> VCompareNameNos { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCompare"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCompare"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VCompare> VCompares { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCraneLocation"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCraneLocation"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VCraneLocation> VCraneLocations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VCraneUnloadlocation"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VCraneUnloadlocation> VCraneUnloadlocations { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VMaterialEventReport"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VMaterialEventReport"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VMaterialEventReport> VMaterialEventReports { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VMaterialEvent"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VMaterialEvent"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VMaterialEvent> VMaterialEvents { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VPlMaterial"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VPlMaterial"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VPlMaterial> VPlMaterials { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VProductionMaterial"/>.
        /// </summary>
        /// <value>
        /// The <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> that can be used to query and save instances of <see cref="WmsApi.Domain.Entities.VProductionMaterial"/>.
        /// </value>
        public virtual DbSet<WmsApi.Domain.Entities.VProductionMaterial> VProductionMaterials { get; set; }

        #endregion

		/// <summary>
		/// Configure the model that was discovered from the entity types exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on this context.
		/// </summary>
		/// <param name="modelBuilder">The builder being used to construct the model for this context.</param>
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			#region Generated Configuration
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TagcopylistMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqCoilCarMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqCraneMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqCraneWeightMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqCrossVehicleMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqFenceAreaMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqFenceDoorMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqGateEntryMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqGateParkingMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqTrainCarMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqTrainMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TEqWalkingBeamMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.Tmmcr01Map());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlAutoCodeMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlBackRepackMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlBackReturnMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlBayMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlBayTransferMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlCraneMaintenanceMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlCraneTaskMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlCrossBayTaskMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlDeliveryPlanMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlFinishLineMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlMaterialMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlOfflineMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlProductionDetailMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlProductionMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlStackTranferMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTrainDeliveryMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckBackMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckDeliveryDetailMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckDeliveryMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckLoadListDetailMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckLoadListMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckQueueInBayOutMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckQueueInBayShiftMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TPlTruckTransferMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcBayMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcCameraIdsMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcClassStockMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcCraneTaskMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcInventoryDetailMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcInventoryMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcInventoryTempMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcLocationMaterialMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcLocationsRateMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcLogMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcMaterialEventMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcMaterialEventMigrateMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcMaterialMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcTelegramMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcTrainDeliveryMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcTrainDeliveryPickMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcTrainNodeMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcTruckBayQueueMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcTruckLoadingLogMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcTruckMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRcWorkModeMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRlCranePlanTypeMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRlDispatchRulesMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRlLocationAssignMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRlLocationMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRlRegionRangeMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TRlTransferPrewiredMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TScAppMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TScClientMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TScColorMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TScDictionaryMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TScTransferSpecMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TScTransferTerminalMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTestPreMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrConveyingChainMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrCplMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrCraneMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrCrossTrainMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrEntryMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrFenceAreaMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrFenceDoorMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrLocationMaterialEventMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrLocationMaterialMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrMessageReceivedMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrMessageSendMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrNetworkMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrParkingPlaceMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrTodoListMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrTrafficLightMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrTrainMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrTruckBayQueueMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrTruckMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrTruckQueueMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TTrUserMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmColSetMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmGroupMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmMenuMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmPermissionMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmRoleMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmRolePermissionMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmShiftMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TUmUserMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhAreaMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhBayMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhCranePassageMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhCraneTravelSpaceMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhDestHouseMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhErrorMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhLocationMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhPlanTypeMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhStackMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhTrainLocationMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhTruckParkingPlaceMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhTruckPassageMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.TWhWarehouseMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VCompareMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VCompareNameNoMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VCraneLocationMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VCraneUnloadlocationMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VMaterialEventMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VMaterialEventReportMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VPlMaterialMap());
            modelBuilder.ApplyConfiguration(new WmsApi.Domain.Mapping.VProductionMaterialMap());
            #endregion
		}
	}
}
