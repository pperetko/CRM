
ALTER TABLE [dbo].[category]   
ADD CONSTRAINT FK_category_categories_types FOREIGN KEY (id_categories_types)     
    REFERENCES [dbo].[categories_types] (id_categories_types)     
        
;    
GO



ALTER TABLE [dbo].[category]
ADD CONSTRAINT FK_category_tab_filters FOREIGN KEY (id_tab_filters)
    REFERENCES [dbo].[tab_filters] (id_tab_filters);




    CREATE TABLE [dbo].[category_sub] (
    id_category_sub [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
    name  varchar(100) NOT NULL,
	show_on_list bit null,
    id_category int FOREIGN KEY REFERENCES category(id_category)
);




ALTER TABLE [dbo].[category]
ADD CONSTRAINT FK_category_filters FOREIGN KEY (id_filters)
    REFERENCES [dbo].[filters] (id_filters)

;
GO






ALTER TABLE [dbo].[category_filters]
ADD CONSTRAINT FK_category_filter FOREIGN KEY (id_category)
    REFERENCES [dbo].[category] (id_category)

;
GO




ALTER TABLE [dbo].[category_filters]
ADD CONSTRAINT FK_filter_category FOREIGN KEY (id_filter)
    REFERENCES [dbo].[filters] (id_filters)

;
GO