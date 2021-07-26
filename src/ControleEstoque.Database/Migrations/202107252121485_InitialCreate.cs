namespace ControleEstoque.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categorias",
                c => new
                    {
                        Codigo = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Codigo);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Codigo = c.Long(nullable: false, identity: true),
                        Nome = c.String(nullable: false, maxLength: 50),
                        Descricao = c.String(nullable: false, maxLength: 200),
                        UnidadeMedida = c.Int(nullable: false),
                        Quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Categoria_Codigo = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Codigo)
                .ForeignKey("dbo.Categorias", t => t.Categoria_Codigo)
                .Index(t => t.Categoria_Codigo);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "Categoria_Codigo", "dbo.Categorias");
            DropIndex("dbo.Produtos", new[] { "Categoria_Codigo" });
            DropTable("dbo.Produtos");
            DropTable("dbo.Categorias");
        }
    }
}
