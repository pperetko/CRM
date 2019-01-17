
ALTER TABLE [dbo].[category]   
ADD CONSTRAINT FK_category_categories_types FOREIGN KEY (id_categories_types)     
    REFERENCES [dbo].[categories_types] (id_categories_types)     
        
;    
GO



ALTER TABLE [dbo].[category]
ADD CONSTRAINT FK_category_tab_filters FOREIGN KEY (id_tab_filters)
    REFERENCES [dbo].[tab_filters] (id_tab_filters);
