
ALTER TABLE [dbo].[category]   
ADD CONSTRAINT FK_category_categories_types FOREIGN KEY (id_categories_types)     
    REFERENCES [dbo].[categories_types] (id_categories_types)     
        
;    
GO    