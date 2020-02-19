using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroService.ApiGatewayAdmin.Web.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayAggregateConfig_AbpApiGatewayAggregate_Aggregat~",
                table: "AbpApiGatewayAggregateConfig");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayBalancerOptions_AbpApiGatewayGlobalConfiguratio~",
                table: "AbpApiGatewayBalancerOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayDiscovery_AbpApiGatewayGlobalConfiguration_Item~",
                table: "AbpApiGatewayDiscovery");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayHttpOptions_AbpApiGatewayGlobalConfiguration_It~",
                table: "AbpApiGatewayHttpOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayQoSOptions_AbpApiGatewayGlobalConfiguration_Ite~",
                table: "AbpApiGatewayQoSOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayRateLimitOptions_AbpApiGatewayGlobalConfigurati~",
                table: "AbpApiGatewayRateLimitOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayRateLimitRule_AbpApiGatewayDynamicReRoute_Dynam~",
                table: "AbpApiGatewayRateLimitRule");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayRateLimitRule_DynamicReRouteId",
                table: "AbpApiGatewayRateLimitRule");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayRateLimitRule_ReRouteId",
                table: "AbpApiGatewayRateLimitRule");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayQoSOptions_ItemId",
                table: "AbpApiGatewayQoSOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayQoSOptions_ReRouteId",
                table: "AbpApiGatewayQoSOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayHttpOptions_ItemId",
                table: "AbpApiGatewayHttpOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayHttpOptions_ReRouteId",
                table: "AbpApiGatewayHttpOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ItemId",
                table: "AbpApiGatewayBalancerOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ReRouteId",
                table: "AbpApiGatewayBalancerOptions");

            migrationBuilder.RenameIndex(
                name: "IX_AbpApiGatewayReRoute_DownstreamPathTemplate_UpstreamPathTemp~",
                table: "AbpApiGatewayReRoute",
                newName: "IX_AbpApiGatewayReRoute_DownstreamPathTemplate_UpstreamPathTemplate");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayServerInfo",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayServerAuth",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewaySecurityOptions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayReRoute",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayRateLimitRule",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayRateLimitOptions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayQoSOptions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayHttpOptions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayHostAndPort",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayHeaders",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AbpApiGatewayGlobalConfiguration",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayGlobalConfiguration",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayDynamicReRoute",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayDiscovery",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayCacheOptions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayBalancerOptions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayAuthOptions",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayAggregateConfig",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayAggregate",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayRateLimitRule_DynamicReRouteId",
                table: "AbpApiGatewayRateLimitRule",
                column: "DynamicReRouteId",
                unique: true,
                filter: "[DynamicReRouteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayRateLimitRule_ReRouteId",
                table: "AbpApiGatewayRateLimitRule",
                column: "ReRouteId",
                unique: true,
                filter: "[ReRouteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayQoSOptions_ItemId",
                table: "AbpApiGatewayQoSOptions",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayQoSOptions_ReRouteId",
                table: "AbpApiGatewayQoSOptions",
                column: "ReRouteId",
                unique: true,
                filter: "[ReRouteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayHttpOptions_ItemId",
                table: "AbpApiGatewayHttpOptions",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayHttpOptions_ReRouteId",
                table: "AbpApiGatewayHttpOptions",
                column: "ReRouteId",
                unique: true,
                filter: "[ReRouteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ItemId",
                table: "AbpApiGatewayBalancerOptions",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ReRouteId",
                table: "AbpApiGatewayBalancerOptions",
                column: "ReRouteId",
                unique: true,
                filter: "[ReRouteId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayAggregateConfig_AbpApiGatewayAggregate_AggregateReRouteId",
                table: "AbpApiGatewayAggregateConfig",
                column: "AggregateReRouteId",
                principalTable: "AbpApiGatewayAggregate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayBalancerOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayBalancerOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayDiscovery_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayDiscovery",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayHttpOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayHttpOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayQoSOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayQoSOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayRateLimitOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayRateLimitOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayRateLimitRule_AbpApiGatewayDynamicReRoute_DynamicReRouteId",
                table: "AbpApiGatewayRateLimitRule",
                column: "DynamicReRouteId",
                principalTable: "AbpApiGatewayDynamicReRoute",
                principalColumn: "DynamicReRouteId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayAggregateConfig_AbpApiGatewayAggregate_AggregateReRouteId",
                table: "AbpApiGatewayAggregateConfig");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayBalancerOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayBalancerOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayDiscovery_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayDiscovery");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayHttpOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayHttpOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayQoSOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayQoSOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayRateLimitOptions_AbpApiGatewayGlobalConfiguration_ItemId",
                table: "AbpApiGatewayRateLimitOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_AbpApiGatewayRateLimitRule_AbpApiGatewayDynamicReRoute_DynamicReRouteId",
                table: "AbpApiGatewayRateLimitRule");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayRateLimitRule_DynamicReRouteId",
                table: "AbpApiGatewayRateLimitRule");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayRateLimitRule_ReRouteId",
                table: "AbpApiGatewayRateLimitRule");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayQoSOptions_ItemId",
                table: "AbpApiGatewayQoSOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayQoSOptions_ReRouteId",
                table: "AbpApiGatewayQoSOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayHttpOptions_ItemId",
                table: "AbpApiGatewayHttpOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayHttpOptions_ReRouteId",
                table: "AbpApiGatewayHttpOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ItemId",
                table: "AbpApiGatewayBalancerOptions");

            migrationBuilder.DropIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ReRouteId",
                table: "AbpApiGatewayBalancerOptions");

            migrationBuilder.RenameIndex(
                name: "IX_AbpApiGatewayReRoute_DownstreamPathTemplate_UpstreamPathTemplate",
                table: "AbpApiGatewayReRoute",
                newName: "IX_AbpApiGatewayReRoute_DownstreamPathTemplate_UpstreamPathTemp~");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayServerInfo",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayServerAuth",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewaySecurityOptions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayReRoute",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayRateLimitRule",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayRateLimitOptions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayQoSOptions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayHttpOptions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayHostAndPort",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayHeaders",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<bool>(
                name: "IsDeleted",
                table: "AbpApiGatewayGlobalConfiguration",
                nullable: false,
                oldClrType: typeof(bool),
                oldDefaultValue: false);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayGlobalConfiguration",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayDynamicReRoute",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayDiscovery",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayCacheOptions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayBalancerOptions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayAuthOptions",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayAggregateConfig",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AbpApiGatewayAggregate",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayRateLimitRule_DynamicReRouteId",
                table: "AbpApiGatewayRateLimitRule",
                column: "DynamicReRouteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayRateLimitRule_ReRouteId",
                table: "AbpApiGatewayRateLimitRule",
                column: "ReRouteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayQoSOptions_ItemId",
                table: "AbpApiGatewayQoSOptions",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayQoSOptions_ReRouteId",
                table: "AbpApiGatewayQoSOptions",
                column: "ReRouteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayHttpOptions_ItemId",
                table: "AbpApiGatewayHttpOptions",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayHttpOptions_ReRouteId",
                table: "AbpApiGatewayHttpOptions",
                column: "ReRouteId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ItemId",
                table: "AbpApiGatewayBalancerOptions",
                column: "ItemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpApiGatewayBalancerOptions_ReRouteId",
                table: "AbpApiGatewayBalancerOptions",
                column: "ReRouteId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayAggregateConfig_AbpApiGatewayAggregate_Aggregat~",
                table: "AbpApiGatewayAggregateConfig",
                column: "AggregateReRouteId",
                principalTable: "AbpApiGatewayAggregate",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayBalancerOptions_AbpApiGatewayGlobalConfiguratio~",
                table: "AbpApiGatewayBalancerOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayDiscovery_AbpApiGatewayGlobalConfiguration_Item~",
                table: "AbpApiGatewayDiscovery",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayHttpOptions_AbpApiGatewayGlobalConfiguration_It~",
                table: "AbpApiGatewayHttpOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayQoSOptions_AbpApiGatewayGlobalConfiguration_Ite~",
                table: "AbpApiGatewayQoSOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayRateLimitOptions_AbpApiGatewayGlobalConfigurati~",
                table: "AbpApiGatewayRateLimitOptions",
                column: "ItemId",
                principalTable: "AbpApiGatewayGlobalConfiguration",
                principalColumn: "ItemId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AbpApiGatewayRateLimitRule_AbpApiGatewayDynamicReRoute_Dynam~",
                table: "AbpApiGatewayRateLimitRule",
                column: "DynamicReRouteId",
                principalTable: "AbpApiGatewayDynamicReRoute",
                principalColumn: "DynamicReRouteId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
