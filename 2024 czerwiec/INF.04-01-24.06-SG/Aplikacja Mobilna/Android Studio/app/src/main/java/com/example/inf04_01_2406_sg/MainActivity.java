package com.example.inf04_01_2406_sg;

import android.os.Bundle;
import android.view.View;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Random;

public class MainActivity extends AppCompatActivity {

    int gameScore = 0;
    TextView tvDrawScore, tvGameScore;
    private ImageView[] diceImages = new ImageView[5];
    private int[] dice = new int[5];

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });
        diceImages[0] = findViewById(R.id.dice1);
        diceImages[1] = findViewById(R.id.dice2);
        diceImages[2] = findViewById(R.id.dice3);
        diceImages[3] = findViewById(R.id.dice4);
        diceImages[4] = findViewById(R.id.dice5);

    }

    public void drawDice(View view) {
        Random random = new Random();

        for (int i = 0; i < 5; i++) {
            dice[i] = random.nextInt(6) + 1;

            int resourceId = getResources().getIdentifier("dice" + dice[i], "drawable", getPackageName());
            diceImages[i].setImageResource(resourceId);
        }
        int drawScore = calculateScore();
        gameScore += drawScore;

        tvDrawScore = findViewById(R.id.drawScore);
        tvGameScore = findViewById(R.id.gameScore);

        tvDrawScore.setText("Wynik tego losowania: " + drawScore);
        tvGameScore.setText("Wynik gry: " + gameScore);
    }

    public void resetScore(View view) {
        tvDrawScore = findViewById(R.id.drawScore);
        tvGameScore = findViewById(R.id.gameScore);

        gameScore = 0;

        tvDrawScore.setText("Wynik tego losowania: 0");
        tvGameScore.setText("Wynik gry: 0");

        for (int i = 0; i < 5; i++) {
            diceImages[i].setImageResource(R.drawable.question_mark_dice);
        }
    }

    public int calculateScore() {
        int points = 0;
        boolean isRepeating = false;

        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if (dice[i] == dice[j] && i != j) {
                    points += dice[j];
                    isRepeating = true;
                    dice[j] = 0;
                }
            }
            if (isRepeating) {
                points += dice[i];
                isRepeating = false;
            }
        }
        return points;
    }
}