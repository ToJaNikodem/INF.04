package com.example.inf04_02_2306_sg;

import android.os.Bundle;
import android.view.View;
import android.widget.SeekBar;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.ArrayList;

public class MainActivity extends AppCompatActivity {

    ArrayList<String> greetings;
    int currentQuoteIndex = 0;

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

        greetings = new ArrayList<>();
        greetings.add("Dzień dobry");
        greetings.add("Good morning");
        greetings.add("Buenos dias");

        SeekBar seekBar = findViewById(R.id.seekBar);
        TextView textSize = findViewById(R.id.textSize);
        TextView greeting = findViewById(R.id.greeting);

        seekBar.setOnSeekBarChangeListener(new SeekBar.OnSeekBarChangeListener() {
            @Override
            public void onProgressChanged(SeekBar seekBar, int i, boolean b) {
                textSize.setText("Rozmiar: " + i);
                greeting.setTextSize(i);
            }

            @Override
            public void onStartTrackingTouch(SeekBar seekBar) {

            }

            @Override
            public void onStopTrackingTouch(SeekBar seekBar) {

            }
        });
    }

    public void changeGreeting(View view) {
        TextView greeting = findViewById(R.id.greeting);

        if (currentQuoteIndex < 2) {
            currentQuoteIndex++;
        } else {
            currentQuoteIndex = 0;
        }
        greeting.setText(greetings.get(currentQuoteIndex));
    }
}