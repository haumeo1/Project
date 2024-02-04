SELECT
    Receipts.Receipt_ID,
    Receipts.Receipt_Date,
    Receipt_Items.Quantity,
    Items.Item_Name,
    Items.Price
FROM
    Receipts
JOIN
    Receipt_Items ON Receipts.Receipt_ID = Receipt_Items.Receipt_ID
JOIN
    Items ON Receipt_Items.Item_ID = Items.Item_ID
WHERE
    Receipts.Receipt_ID = 123456; -- Replace with the desired Receipt_ID
