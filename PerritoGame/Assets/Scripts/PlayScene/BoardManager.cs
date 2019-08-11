using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public static BoardManager instance;
    public List<Sprite> characters = new List<Sprite>();
    public GameObject tile;
    public int xSize, ySize;
    public GameObject boardPanel;

    private GameObject[,] tiles;

    public bool IsShifting { get; set; }

    void Start () {
        instance = GetComponent<BoardManager>();

        //Vector2 offset = tile.GetComponent<SpriteRenderer>().bounds.size;
        var panelSize = boardPanel.GetComponent<RectTransform>().rect;

        Vector2 offset = new Vector2();
        offset.x = panelSize.width / xSize;
        offset.y = panelSize.height / ySize;
        CreateBoard(offset.x, offset.y);
    }

    private void CreateBoard (float xOffset, float yOffset) {
        tiles = new GameObject[xSize, ySize];

        float startX = boardPanel.transform.position.x;
        float startY = boardPanel.transform.position.y;

        for (int x = 0; x < xSize; x++) {
            for (int y = 0; y < ySize; y++) {
                GameObject newTile = Instantiate(tile, new Vector3(startX + (xOffset * x), startY + (yOffset * y), 0), tile.transform.rotation);
                newTile.transform.SetParent(boardPanel.transform, true);
                tiles[x, y] = newTile;
            }
        }
    }
}
